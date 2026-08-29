namespace BudgetBoss.Domain.Entities;

public abstract class HardDeleteBaseEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    
    public DateTimeOffset CreatedAt { get; set; }
    
    public DateTimeOffset UpdatedAt { get; set; }
    
}
