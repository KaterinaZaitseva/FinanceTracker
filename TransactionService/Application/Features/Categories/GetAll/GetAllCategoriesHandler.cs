using MediatR;
using Microsoft.EntityFrameworkCore;
using TransactionService.Infrastructure;

namespace TransactionService.Application.Features.Categories.GetAll;

public class GetAllCategoriesHandler(TransactionDbContext context) 
    : IRequestHandler<GetAllCategoriesQuery, IEnumerable<CategoryListItemResponse>>
{
    public async Task<IEnumerable<CategoryListItemResponse>> Handle(
        GetAllCategoriesQuery request, 
        CancellationToken cancellationToken)
    {
        IEnumerable<CategoryListItemResponse>? collection =
            await context.Categories
                .AsNoTracking()
                .Select(c => new CategoryListItemResponse(
                    c.Id,
                    c.Name
                )).ToListAsync(cancellationToken: cancellationToken);
        
            return collection;
    }
}