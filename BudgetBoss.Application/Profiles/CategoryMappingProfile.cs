using AutoMapper;
using BudgetBoss.Application.DTOs.Requests;
using BudgetBoss.Application.DTOs.Responses;
using BudgetBoss.Domain.Entities;

namespace BudgetBoss.Application.Profiles;

public class CategoryMappingProfile : Profile
{

    public CategoryMappingProfile()
    {
        CreateMap<CategoryRequestDto, Category>();

        CreateMap<Category, CategoryResponseDto>();
    }
    
}
