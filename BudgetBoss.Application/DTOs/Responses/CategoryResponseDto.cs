namespace BudgetBoss.Application.DTOs.Responses;

public class CategoryResponseDto
{
    public Guid Id { get; set; }
    
    public required string Name { get; set; }

    public string? Color { get; set; }

    public string? Icon { get; set; }
}
