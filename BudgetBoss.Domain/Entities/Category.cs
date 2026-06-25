namespace BudgetBoss.Domain.Entities;

public class Category : SoftDeleteBaseEntity
{
    public required string Name { get; set; }

    public string? Color { get; set; }

    public string? Icon { get; set; }

    public Guid WorkspaceId { get; set; }
    
}
