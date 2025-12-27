using MediatR;
using Microsoft.EntityFrameworkCore;
using TransactionService.Infrastructure;

namespace TransactionService.Application.Features.Transactions.GetAll;

public class GetAllTransactionHandler(TransactionDbContext context) 
    : IRequestHandler<GetAllTransactionsQuery, IEnumerable<TransactionListItemResponse>>
{
    public async Task<IEnumerable<TransactionListItemResponse>> Handle(
        GetAllTransactionsQuery request, 
        CancellationToken cancellationToken)
    {
        IEnumerable<TransactionListItemResponse>? collection =
            await context.Transactions
                .AsNoTracking()
                .Select(t => new TransactionListItemResponse(
                    t.Id,
                    t.Amount,
                    t.Type,
                    t.CreatedAt,
                    t.CategoryId)
                ).ToListAsync(cancellationToken: cancellationToken);
        
            return collection;
    }
}