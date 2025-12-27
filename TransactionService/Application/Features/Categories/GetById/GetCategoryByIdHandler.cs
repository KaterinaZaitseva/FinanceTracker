using MediatR;
using Microsoft.EntityFrameworkCore;
using TransactionService.Application.Features.Transactions.GetById;
using TransactionService.Infrastructure;

namespace TransactionService.Application.Features.Categories.GetById;

public class GetCategoryByIdHandler(TransactionDbContext context) 
    : IRequestHandler<GetCategoryByIdQuery, CategoryResponse?>
{
    public async Task<CategoryResponse?> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        return await context.Categories
            .AsNoTracking()
            .Where(c => c.Id == request.Id)
            .Select(c => new CategoryResponse(
                c.Id,
                c.Name
            )).FirstOrDefaultAsync(cancellationToken);
    }
}