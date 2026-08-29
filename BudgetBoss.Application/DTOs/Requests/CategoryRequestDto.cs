namespace BudgetBoss.Application.DTOs.Requests;

public class CategoryRequestDto
{
    public required string Name { get; set; }

    public string? Color { get; set; }

    public string? Icon { get; set; }

}
