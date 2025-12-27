using MediatR;

namespace TransactionService.Application.Features.Categories.GetAll;

public record GetAllCategoriesQuery() : IRequest<IEnumerable<CategoryListItemResponse>>;