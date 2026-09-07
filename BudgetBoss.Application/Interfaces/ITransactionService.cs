using BudgetBoss.Application.DTOs.Requests;
using BudgetBoss.Application.DTOs.Responses;
using Transaction = BudgetBoss.Domain.Entities.Transaction;

namespace BudgetBoss.Application.Interfaces;

public interface ITransactionService
{
    Task<TransactionResponseDto> CreateTransactionAsync(TransactionRequestDto transactionRequestDto,Guid workspaceId, Guid creatorId); 
    
    Task<ICollection<TransactionResponseDto>> GetAllTransactions(Guid workspaceId);
    
    Task<ICollection<TransactionResponseDto>> GetAllTransactionsByCategoryAsync(Guid workspaceId,  Guid categoryId);
    
    Task<TransactionResponseDto?> GetTransactionByIdAsync(Guid workspaceId, Guid id);
    
    Task<TransactionResponseDto?> UpdateTransactionAsync(TransactionRequestDto transaction, Guid workspaceId, Guid transactionId);
    
    Task<bool> DeleteTransactionAsync(Guid workspaceId, Guid id);
    
}
