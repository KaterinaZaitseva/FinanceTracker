using MediatR;

namespace TransactionService.Application.Features.Categories.Delete;

public record DeleteCategoryCommand(Guid Id) : IRequest;