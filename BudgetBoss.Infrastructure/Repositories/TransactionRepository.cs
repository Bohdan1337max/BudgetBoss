using Transaction = BudgetBoss.Domain.Entities.Transaction;
using BudgetBoss.Application.Interfaces;
using BudgetBoss.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BudgetBoss.Infrastructure.Repositories;

public class TransactionRepository(BudgetBossDbContext context) :  ITransactionRepository
{
    
    private readonly BudgetBossDbContext _context = context;
    
    public async Task<Transaction> AddTransactionAsync(Transaction transaction)
    {
        
        await _context.Transactions.AddAsync(transaction);
        await _context.SaveChangesAsync();
        
        var transactionFromDb = await _context.Transactions
            .Include(t => t.CreatedByUser)
            .Include(t => t.Category)
            .FirstOrDefaultAsync(t => t.Id == transaction.Id && t.WorkspaceId == transaction.WorkspaceId);

        return transactionFromDb;
    }

    public async Task<bool> DeleteTransactionAsync(Guid workspaceId, Guid id)
    {
        var transactionToDelete = await _context.Transactions.FirstOrDefaultAsync(t => t.WorkspaceId == workspaceId && t.Id == id);
        if(transactionToDelete == null)
            return false;
        
        transactionToDelete.DeletedAt = DateTime.UtcNow;
        await _context.SaveChangesAsync();
        
        return true;
    }

    public async Task<List<Transaction>> GetAllTransactionsAsync(Guid workspaceId)
    {
        var transactions = await _context.Transactions.Where(t => t.WorkspaceId == workspaceId)
            .Include(t => t.CreatedByUser)
            .Include(t => t.Category)
          .ToListAsync();
        
        return transactions;
    }

    public async Task<List<Transaction>> GetAllTransactionsByCategoryAsync(Guid workspaceId, Guid categoryId)
    {
        var transactions = await _context.Transactions.Where(t => t.WorkspaceId == workspaceId && t.CategoryId == categoryId)
            .Include(t => t.CreatedByUser)
            .Include(t => t.Category)
            .ToListAsync();
        
        return transactions;
    }

    public async Task<Transaction?> GetTransactionByIdAsync(Guid workspaceId, Guid id)
    {
        var transaction = await _context.Transactions
            .Include(t => t.CreatedByUser)
            .Include(t => t.Category)
            .FirstOrDefaultAsync(t => t.WorkspaceId == workspaceId && t.Id == id);
        return transaction;
    }

    public async Task<Transaction?> UpdateTransactionAsync(Transaction transaction)
    {
        var transactionToUpdate = await _context.Transactions.FirstOrDefaultAsync(t => t.Id == transaction.Id &&  t.WorkspaceId == transaction.WorkspaceId);
        if(transactionToUpdate == null)
            return null;
        
        //TODO Update
        transactionToUpdate.Description = transaction.Description;
        transactionToUpdate.Amount = transaction.Amount;
        
        await _context.SaveChangesAsync();
        
        return transactionToUpdate;
        
    }
}
