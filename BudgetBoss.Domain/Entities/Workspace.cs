using System.ComponentModel.DataAnnotations;

namespace BudgetBoss.Domain.Entities;

public class Workspace : SoftDeleteBaseEntity
{
    public required string Name { get; set; }
    
    public Guid CreatedByUserId { get; set; }
    
}
