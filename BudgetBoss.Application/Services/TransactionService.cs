using Transaction = BudgetBoss.Domain.Entities.Transaction;
using AutoMapper;
using BudgetBoss.Application.DTOs.Requests;
using BudgetBoss.Application.DTOs.Responses;
using BudgetBoss.Application.Interfaces;
using BudgetBoss.Domain.Entities;

namespace BudgetBoss.Application.Services;

public class TransactionService(ITransactionRepository transactionRepository, IMapper mapper) : ITransactionService
{
    private readonly IMapper _mapper = mapper;
    private readonly ITransactionRepository _transactionRepository = transactionRepository;

    public async Task<TransactionResponseDto> CreateTransactionAsync(TransactionRequestDto transactionRequestDto, Guid workspaceId, Guid creatorId)
    {
        var request = _mapper.Map<TransactionRequestDto, Transaction>(transactionRequestDto);
        request.WorkspaceId = workspaceId;
        request.CreatedByUserId = creatorId;
        var response = await _transactionRepository.AddTransactionAsync(request);
        return _mapper.Map<Transaction, TransactionResponseDto>(response);            
            
    }

    public async Task<ICollection<TransactionResponseDto>> GetAllTransactions(Guid workspaceId)
    {
        var response = await _transactionRepository.GetAllTransactionsAsync(workspaceId);
        
       return _mapper.Map<ICollection<Transaction>,ICollection<TransactionResponseDto>>(response);
    }

    public async Task<ICollection<TransactionResponseDto>> GetAllTransactionsByCategoryAsync(Guid workspaceId, Guid categoryId)
    {
        var response = await _transactionRepository.GetAllTransactionsByCategoryAsync(workspaceId, categoryId);
        
        return _mapper.Map<ICollection<Transaction>,ICollection<TransactionResponseDto>>(response);
    }

    public async Task<TransactionResponseDto?> GetTransactionByIdAsync(Guid workspaceId, Guid id)
    {
        var response = await _transactionRepository.GetTransactionByIdAsync(workspaceId, id);
        
        return _mapper.Map<Transaction, TransactionResponseDto>(response);
    }

    public async Task<TransactionResponseDto?> UpdateTransactionAsync(TransactionRequestDto transaction, Guid workspaceId, Guid transactionId)
    {
        var  request = _mapper.Map<TransactionRequestDto, Transaction>(transaction);
        request.WorkspaceId = workspaceId;
        request.Id = transactionId;
        
        var response = await _transactionRepository.UpdateTransactionAsync(request);
        
        return response == null ? null : _mapper.Map<Transaction, TransactionResponseDto>(response);
    }

    public async Task<bool> DeleteTransactionAsync(Guid workspaceId, Guid id)
    {
        var response = await _transactionRepository.DeleteTransactionAsync(workspaceId, id);
        
        return response;
    }
}