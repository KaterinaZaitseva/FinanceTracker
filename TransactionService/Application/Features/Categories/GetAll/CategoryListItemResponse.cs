namespace TransactionService.Application.Features.Categories.GetAll;

public record CategoryListItemResponse(
    Guid Id,
    string? Name
);