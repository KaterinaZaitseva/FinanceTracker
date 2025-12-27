using MediatR;

namespace TransactionService.Application.Features.Categories.Create;

public record CreateCategoryCommand(
    string Name
) : IRequest;