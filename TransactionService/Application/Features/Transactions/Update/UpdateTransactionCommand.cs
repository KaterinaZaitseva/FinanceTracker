using MediatR;
using TransactionService.Domain;

namespace TransactionService.Application.Features.Transactions.Update;

public record UpdateTransactionCommand(
    Guid Id,
    decimal Amount,
    TransactionType Type,
    Guid? CategoryId
) : IRequest;