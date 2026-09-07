using AutoMapper;
using BudgetBoss.Application.DTOs.Requests;
using BudgetBoss.Application.DTOs.Responses;
using BudgetBoss.Domain.Entities;

namespace BudgetBoss.Application.Profiles;

public class TransactionMappingProfile : Profile
{
    public TransactionMappingProfile()
    {
        CreateMap<Transaction, TransactionResponseDto>()
            .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category == null ? null : new CategoryResponseDto
            {
                Id = src.Category.Id,
                Name = src.Category.Name,
                Color = src.Category.Color,
                Icon = src.Category.Icon
            }))
            .ForMember(dest => dest.CreatorName, opt => opt.MapFrom(src => src.CreatedByUser.Name));
        CreateMap<TransactionRequestDto, Transaction>();
    }
}
