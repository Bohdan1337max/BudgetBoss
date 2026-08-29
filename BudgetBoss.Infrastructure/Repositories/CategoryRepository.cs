using BudgetBoss.Application.Interfaces;
using BudgetBoss.Domain.Entities;
using BudgetBoss.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BudgetBoss.Infrastructure.Repositories;

public class CategoryRepository(BudgetBossDbContext context) : ICategoryRepository
{
    private readonly BudgetBossDbContext _context = context;

    public async Task<Category> AddCategoryAsync(Category category)
    {
        
        await _context.Categories.AddAsync(category);
        await _context.SaveChangesAsync();
        
        return category;
    }

    public async Task<bool> DeleteCategoryAsync(Guid id, Guid workspaceId)
    {
        var categoryToDelete = await _context.Categories.FirstOrDefaultAsync(category => category.Id == id && category.WorkspaceId == workspaceId);
        if(categoryToDelete == null)
            return false;

        categoryToDelete.DeletedAt = DateTimeOffset.UtcNow;
        await _context.SaveChangesAsync();
        
        return true;
    }

    public async Task<List<Category>> GetAllCategoriesAsync(Guid workspaceId)
    {
       var categories = await _context.Categories.Where(category => category.WorkspaceId == workspaceId).Where(category => category.DeletedAt == null).ToListAsync();
       
       return categories;
    }

    public async Task<Category?> GetCategoryByIdAsync(Guid id, Guid workspaceId)
    {
        var category = await _context.Categories.Where(category => category.Id == id && category.WorkspaceId == workspaceId && category.DeletedAt == null).FirstOrDefaultAsync();

        return category;
    }

    public async Task<Category?> UpdateCategoryAsync(Category category)
    {
        var categoryToUpdate = await _context.Categories.FirstOrDefaultAsync(c => c.Id == category.Id && c.WorkspaceId == category.WorkspaceId);

        if (categoryToUpdate == null)
            return null;

        categoryToUpdate.Name = category.Name;
        categoryToUpdate.Color = category.Color;
        categoryToUpdate.Icon = category.Icon;
        await _context.SaveChangesAsync();
        
        return categoryToUpdate;
    }
}
