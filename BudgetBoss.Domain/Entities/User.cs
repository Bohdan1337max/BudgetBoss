using System.ComponentModel.DataAnnotations;

namespace BudgetBoss.Domain.Entities;

public class User : SoftDeleteBaseEntity
{
    public required string Name { get; set; }
    
    public required string Email { get; set; }
    
    public required string PasswordHash { get; set; }
}
