using BudgetBoss.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BudgetBoss.Infrastructure.Context;

public class BudgetBossDbContext(DbContextOptions<BudgetBossDbContext> options) : DbContext(options)
{
    public DbSet<Budget> Budgets { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Transaction> Transactions { get; set; }
    
    public DbSet<User> Users { get; set; }

    public DbSet<Workspace> Workspaces { get; set; }

    public DbSet<WorkspaceMember> WorkspaceMembers { get; set; }

    public async override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var now = DateTimeOffset.UtcNow;

        var entries = ChangeTracker.Entries<HardDeleteBaseEntity>();

        foreach (var entry in entries)
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedAt = now;
                    entry.Entity.UpdatedAt = now;
                    break;
                case EntityState.Modified:
                    entry.Entity.UpdatedAt = now;
                    break;
            }
        } 
        return await base.SaveChangesAsync(cancellationToken);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Budget>().HasOne(b => b.Category).WithMany()
            .HasForeignKey(b => b.CategoryId).OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Budget>()
            .HasOne<Workspace>()
            .WithMany()
            .HasForeignKey(b => b.WorkspaceId).OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Category>()
            .HasOne<Workspace>()
            .WithMany()
            .HasForeignKey(c => c.WorkspaceId).OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Transaction>().HasOne(t => t.Category).WithMany()
            .HasForeignKey(t => t.CategoryId).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Transaction>()
            .HasOne(t => t.CreatedByUser)
            .WithMany()
            .HasForeignKey(t => t.CreatedByUserId).OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Transaction>()
            .HasOne<Workspace>()
            .WithMany()
            .HasForeignKey(t => t.WorkspaceId).OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Workspace>()
            .HasOne<User>()
            .WithMany()
            .HasForeignKey(w => w.CreatedByUserId).OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<WorkspaceMember>()
            .HasOne<User>()
            .WithMany()
            .HasForeignKey(w => w.UserId).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<WorkspaceMember>()
            .HasOne<Workspace>()
            .WithMany()
            .HasForeignKey(w => w.WorkspaceId).OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Budget>()
            .HasIndex(b => new { b.WorkspaceId, b.CategoryId, b.Date })
            .IsUnique();
        
        modelBuilder.Entity<Transaction>()
            .HasIndex(t => new { t.WorkspaceId, t.CategoryId });
        
        
        modelBuilder.Entity<Category>().HasQueryFilter(c => c.DeletedAt == null);
        modelBuilder.Entity<Transaction>().HasQueryFilter(c => c.DeletedAt == null);
        modelBuilder.Entity<User>().HasQueryFilter(c => c.DeletedAt == null);
        modelBuilder.Entity<Budget>().HasQueryFilter(c => c.DeletedAt == null);
        modelBuilder.Entity<Workspace>().HasQueryFilter(c => c.DeletedAt == null);
    }
}
