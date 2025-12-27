using MediatR;
using TransactionService.Domain;

namespace TransactionService.Application.Features.Transactions.Create;

public record CreateTransactionCommand(
    decimal Amount,
    TransactionType Type,
    Guid? CategoryId
) : IRequest;