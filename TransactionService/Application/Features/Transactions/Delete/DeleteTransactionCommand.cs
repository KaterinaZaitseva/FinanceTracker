using MediatR;

namespace TransactionService.Application.Features.Transactions.Delete;

public record DeleteTransactionCommand(Guid Id) : IRequest;