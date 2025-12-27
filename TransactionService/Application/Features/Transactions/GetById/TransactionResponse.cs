using TransactionService.Domain;

namespace TransactionService.Application.Features.Transactions.GetById;

public record TransactionResponse(
    Guid Id,
    decimal Amount,
    TransactionType Type,
    DateTime CreatedAt,
    Category? Category
);