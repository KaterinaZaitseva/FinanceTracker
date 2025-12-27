using MediatR;
using TransactionService.Domain;

namespace TransactionService.Application.Features.Transactions.Update;

public record UpdateCategoryCommand(
    Guid Id,
    string? Name
) : IRequest;