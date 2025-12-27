using MediatR;

namespace TransactionService.Application.Features.Transactions.GetById;

public record GetTransactionByIdQuery(Guid Id) : IRequest<TransactionResponse>;