namespace BudgetBoss.Domain.Entities;

public class Transaction : SoftDeleteBaseEntity
{

    public decimal Amount { get; set; }

    public string? Description { get; set; }

    public DateOnly Date { get; set; }

    public Guid CreatedByUserId { get; set; }

    public Guid WorkspaceId { get; set; }

    public Guid CategoryId { get; set; }

    public Category Category { get; set; } = null!;

    public User CreatedByUser { get; set; } = null!;

}
