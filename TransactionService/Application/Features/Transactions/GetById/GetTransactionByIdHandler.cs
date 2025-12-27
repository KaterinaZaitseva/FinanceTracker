using MediatR;
using Microsoft.EntityFrameworkCore;
using TransactionService.Infrastructure;

namespace TransactionService.Application.Features.Transactions.GetById;

public class GetTransactionByIdHandler(TransactionDbContext context) 
    : IRequestHandler<GetTransactionByIdQuery, TransactionResponse?>
{
    public async Task<TransactionResponse?> Handle(GetTransactionByIdQuery request, CancellationToken cancellationToken)
    {
        return await context.Transactions
            .AsNoTracking()
            .Where(t => t.Id == request.Id)
            .Select(t => new TransactionResponse(
                t.Id,
                t.Amount,
                t.Type,
                t.CreatedAt,
                t.Category
            )).FirstOrDefaultAsync(cancellationToken);
    }
}