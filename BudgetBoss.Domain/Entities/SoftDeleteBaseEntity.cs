namespace BudgetBoss.Domain.Entities;

public abstract class SoftDeleteBaseEntity : HardDeleteBaseEntity
{
    public DateTimeOffset? DeletedAt { get; set; }
}

