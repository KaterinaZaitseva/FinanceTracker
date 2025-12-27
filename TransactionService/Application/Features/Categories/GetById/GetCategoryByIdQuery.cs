using MediatR;

namespace TransactionService.Application.Features.Categories.GetById;

public record GetCategoryByIdQuery(Guid Id) : IRequest<CategoryResponse>;