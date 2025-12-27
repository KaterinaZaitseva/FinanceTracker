using TransactionService.Domain;

namespace TransactionService.Application.Features.Transactions.GetAll;

public record TransactionListItemResponse(
    Guid Id,
    decimal Amount,
    TransactionType Type,
    DateTime CreatedAt,
    Guid? CategoryId
);