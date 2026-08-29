using BudgetBoss.Application.DTOs;
using BudgetBoss.Domain.Entities;

namespace BudgetBoss.Application.Interfaces;

public interface ICategoryRepository
{
    Task<Category> AddCategoryAsync(Category category); 
    
    Task<bool> DeleteCategoryAsync(Guid workspaceId, Guid id);
    
    Task<List<Category>> GetAllCategoriesAsync(Guid workspaceId );
    
    Task<Category?> GetCategoryByIdAsync(Guid workspaceId, Guid id);

    Task<Category?> UpdateCategoryAsync(Category category);
    
    }
