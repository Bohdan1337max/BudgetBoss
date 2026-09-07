using BudgetBoss.Domain.Entities;

namespace BudgetBoss.Application.Interfaces;

public interface IBudgetRepository
{
    Task<Budget> AddBudgetAsync(Budget budget); 
    
    Task<bool> DeleteBudgetAsync(Guid workspaceId, Guid id);
    
    Task<List<Budget>> GetAllBudgetsAsync(Guid workspaceId );
    
    Task<Budget?> GetBudgetByIdAsync(Guid workspaceId, Guid id);

    Task<Budget?> UpdateBudgetAsync(Budget budget);

}
