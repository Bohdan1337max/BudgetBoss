using BudgetBoss.Application.DTOs.Requests;
using BudgetBoss.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BudgetBoss.Controllers;
[ApiController]
[Route("api/transaction")]
public class TransactionController(ITransactionService transactionService) : ControllerBase
{
        
    [HttpPost("create/{workspaceId:guid}/creator{creatorId:guid}")]
    public async Task<IActionResult> CreateTransaction(TransactionRequestDto request, Guid workspaceId, Guid creatorId)
    {
        var response = await transactionService.CreateTransactionAsync(request, workspaceId, creatorId);
        return Ok(response);
    }
    
    [HttpGet("all-transactions/{workspaceId:guid}/category{categoryId:guid}")]
    public async Task<IActionResult> GetAllTransactionsByCategory(Guid workspaceId, Guid categoryId)
    {
        var response = await transactionService.GetAllTransactionsByCategoryAsync(workspaceId, categoryId);
        return Ok(response);
    }
    
    [HttpGet("workspace/{workspaceId:guid}/transaction{transactionId:guid}")]
    public async Task<IActionResult> GetAllTransactionsById(Guid workspaceId, Guid transactionId)
    {
        var response = await transactionService.GetTransactionByIdAsync(workspaceId, transactionId);
        return Ok(response);
    }
    
    [HttpGet("all-transactions/{workspaceId:guid}")]
    public async Task<IActionResult> GetAllTransactions(Guid workspaceId)
    {
        var response = await transactionService.GetAllTransactions(workspaceId);
        
        return Ok(response);
    }

    [HttpPut("workspace/{workspaceId:guid}/transaction/{transactionId:guid}")]
    public async Task<IActionResult> UpdateTransaction(TransactionRequestDto transaction, Guid workspaceId, Guid transactionId)
    {
        var response = await transactionService.UpdateTransactionAsync(transaction, workspaceId, transactionId);
        
        if(response == null)
            return NotFound();
        
        return Ok(response);
    }

    [HttpDelete("workspace/{workspaceId:guid}/transaction/{transactionId:guid}")]
    public async Task<IActionResult> DeleteTransaction(Guid workspaceId, Guid transactionId)
    {
        var response = await transactionService.DeleteTransactionAsync(workspaceId, transactionId);

        if(response == false)
            return NotFound();
        
        return Ok(new { Message = "Transaction deleted successfully" });;
    }
    
}
