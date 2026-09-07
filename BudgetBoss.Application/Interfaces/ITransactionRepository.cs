using Transaction = BudgetBoss.Domain.Entities.Transaction;


namespace BudgetBoss.Application.Interfaces;

public interface ITransactionRepository
{
    Task<Transaction> AddTransactionAsync(Transaction transaction); 
    
    Task<bool> DeleteTransactionAsync(Guid workspaceId, Guid id);
    
    Task<List<Transaction>> GetAllTransactionsAsync(Guid workspaceId);
    
    Task<List<Transaction>> GetAllTransactionsByCategoryAsync(Guid workspaceId,  Guid categoryId);
    
    Task<Transaction?> GetTransactionByIdAsync(Guid workspaceId, Guid id);

    Task<Transaction?> UpdateTransactionAsync(Transaction transaction);
}
