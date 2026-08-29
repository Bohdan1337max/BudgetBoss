using BudgetBoss.Application.DTOs.Requests;
using BudgetBoss.Application.DTOs.Responses;
using BudgetBoss.Domain.Entities;

namespace BudgetBoss.Application.Interfaces;

public interface ICategoryService
{
    public Task<CategoryResponseDto> CreateCategory(CategoryRequestDto categoryRequestDto, Guid workspaceId);
    
    public Task<CategoryResponseDto?> UpdateCategory(CategoryRequestDto categoryRequestDto,  Guid workspaceId, Guid categoryId);
    
    public Task<bool> DeleteCategory(Guid workspaceId,  Guid categoryId);
    
    public Task<ICollection<CategoryResponseDto>> GetAllCategories(Guid workspaceId);
    
    public Task<CategoryResponseDto?> GetCategoryById(Guid workspaceId,  Guid categoryId);
    
}
