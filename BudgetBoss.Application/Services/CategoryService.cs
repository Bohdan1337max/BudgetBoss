using AutoMapper;
using BudgetBoss.Application.DTOs.Requests;
using BudgetBoss.Application.DTOs.Responses;
using BudgetBoss.Application.Interfaces;
using BudgetBoss.Domain.Entities;

namespace BudgetBoss.Application.Services;

public class CategoryService(ICategoryRepository categoryRepository, IMapper mapper) : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository = categoryRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<CategoryResponseDto> CreateCategory(CategoryRequestDto categoryRequestDto, Guid workspaceId)
    {
        var requestCategory =  _mapper.Map<CategoryRequestDto, Category>(categoryRequestDto);
        
        requestCategory.WorkspaceId = workspaceId;
        
        var result = await _categoryRepository.AddCategoryAsync(requestCategory);
        
        return _mapper.Map<Category, CategoryResponseDto>(result);
    }

    public async Task<CategoryResponseDto?> UpdateCategory(CategoryRequestDto categoryRequestDto, Guid workspaceId, Guid categoryId)
    {
        var  requestCategory = _mapper.Map<CategoryRequestDto, Category>(categoryRequestDto);
        requestCategory.WorkspaceId = workspaceId;
        requestCategory.Id = categoryId;
        
        var result = await _categoryRepository.UpdateCategoryAsync(requestCategory);

        if (result == null)
            return null;
        
        return _mapper.Map<Category, CategoryResponseDto>(result);
    }

    public async Task<bool> DeleteCategory(Guid workspaceId, Guid categoryId)
    {
        var result = await _categoryRepository.DeleteCategoryAsync(workspaceId, categoryId);
        
        return result;
    }

    public async Task<ICollection<CategoryResponseDto>> GetAllCategories(Guid workspaceId)
    {
        var response = await _categoryRepository.GetAllCategoriesAsync(workspaceId);
        
        return _mapper.Map<ICollection<Category>, ICollection<CategoryResponseDto>>(response);
    }

    public async Task<CategoryResponseDto?> GetCategoryById(Guid workspaceId , Guid categoryId)
    {
       var response = await _categoryRepository.GetCategoryByIdAsync(workspaceId, categoryId);
       
       if (response == null)
           return null;
       
       return _mapper.Map<Category, CategoryResponseDto>(response);
    }
}
