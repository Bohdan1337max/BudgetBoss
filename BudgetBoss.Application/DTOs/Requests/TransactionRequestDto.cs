namespace BudgetBoss.Application.DTOs.Requests;

public class TransactionRequestDto
{
    public decimal Amount { get; set; }

    public string? Description { get; set; }

    public DateOnly Date { get; set; }
    
    public Guid CategoryId { get; set; }
}
