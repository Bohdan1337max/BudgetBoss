namespace BudgetBoss.Application.DTOs;

public class UpdateCategoryDto
{
    public required string Name { get; set; }

    public string? Color { get; set; }

    public string? Icon { get; set; }

    public Guid WorkspaceId { get; set; }
}
