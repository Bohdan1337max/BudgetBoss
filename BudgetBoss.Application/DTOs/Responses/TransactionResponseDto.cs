namespace BudgetBoss.Application.DTOs.Responses;

public class TransactionResponseDto
{
    public Guid Id { get; set; }
    
    public decimal Amount { get; set; }

    public string? Description { get; set; }

    public DateOnly Date { get; set; }
    
    public CategoryResponseDto? Category { get; set; }
    
    public string CreatorName { get; set; }
}
