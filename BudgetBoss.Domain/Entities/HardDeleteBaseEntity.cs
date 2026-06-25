namespace BudgetBoss.Domain.Entities;

public abstract class HardDeleteBaseEntity
{
    public Guid Id { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    
    public DateTimeOffset UpdatedAt { get; set; }
    
}
