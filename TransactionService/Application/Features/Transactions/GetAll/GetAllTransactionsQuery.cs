using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using TransactionService.Domain;

namespace TransactionService.Application.Features.Transactions.GetAll;

public record GetAllTransactionsQuery() : IRequest<IEnumerable<TransactionListItemResponse>>;