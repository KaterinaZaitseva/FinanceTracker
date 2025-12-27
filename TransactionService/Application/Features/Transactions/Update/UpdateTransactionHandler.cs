using MediatR;
using TransactionService.Domain;
using TransactionService.Infrastructure;

namespace TransactionService.Application.Features.Transactions.Update;

public class UpdateTransactionHandler(TransactionDbContext context) : IRequestHandler<UpdateTransactionCommand>
{
    public async Task Handle(UpdateTransactionCommand request, CancellationToken cancellationToken)
    {
        var transaction = await context.Transactions.FindAsync([request.Id], cancellationToken);

        if (transaction == null)
            return;
        
        transaction.Amount = request.Amount;
        transaction.Type = request.Type;
        transaction.CategoryId = request.CategoryId;

        await context.SaveChangesAsync(cancellationToken);
    }
}