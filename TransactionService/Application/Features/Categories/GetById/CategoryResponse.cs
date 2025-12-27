using TransactionService.Domain;

namespace TransactionService.Application.Features.Categories.GetById;

public record CategoryResponse(
    Guid Id,
    string? Name
);