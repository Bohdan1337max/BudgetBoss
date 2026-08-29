using AutoMapper;
using BudgetBoss.Application.DTOs.Requests;
using BudgetBoss.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BudgetBoss.Controllers;

[ApiController]
[Route("api/category")]
public class CategoryController(ICategoryService categoryService) : ControllerBase
{
    
    [HttpPost("create/{workspaceId:guid}")]
    public async Task<IActionResult> CreateCategory(CategoryRequestDto request, Guid workspaceId)
    {
        var response = await categoryService.CreateCategory(request, workspaceId);
        return Ok(response);
    }

    [HttpGet("all-categories/{workspaceId:guid}")]
    public async Task<IActionResult> GetCategories(Guid workspaceId)
    {
        var response = await categoryService.GetAllCategories(workspaceId);

        return Ok(response);
    }
    
    [HttpGet("workspace/{workspaceId:guid}/category/{categoryId:guid}")]
    public async Task<IActionResult> GetCategoryById(Guid workspaceId, Guid categoryId)
    {
        var response = await categoryService.GetCategoryById(workspaceId, categoryId);

        if (response == null)
        {
            return NotFound();
        }

        return Ok(response);
    }
    [HttpPut("workspace/{workspaceId:guid}/category/{categoryId:guid}")]
    public async Task<IActionResult> UpdateCategory([FromBody]CategoryRequestDto categoryRequestDto, Guid workspaceId, Guid categoryId)
    {
        var response = await categoryService.UpdateCategory(categoryRequestDto, workspaceId, categoryId);

        if (response == null)
        {
            return NotFound();
        }
        
        return Ok(response);
        
    }
    [HttpDelete("workspace/{workspaceId:guid}/category/{categoryId:guid}")]
    public async Task<IActionResult> DeleteCategory(Guid workspaceId, Guid categoryId)
    {
        var isRequestSuccess = await categoryService.DeleteCategory(workspaceId, categoryId);
        if (!isRequestSuccess)
        {
            return NotFound();
        }

        return Ok(new { Message = "Category deleted successfully" });
    }
}
