using System.Reflection.Metadata;

namespace BudgetBoss.Domain.Entities;

public class Budget : SoftDeleteBaseEntity
{
    public DateOnly Date { get; set; }

    public decimal LimitAmount { get; set; }

    public Guid WorkspaceId { get; set; }

    public Guid CategoryId { get; set; }

    public Category? Category { get; set; }
}
