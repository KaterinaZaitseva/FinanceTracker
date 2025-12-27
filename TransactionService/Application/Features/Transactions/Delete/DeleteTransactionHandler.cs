using MediatR;
using TransactionService.Infrastructure;

namespace TransactionService.Application.Features.Transactions.Delete;

public class DeleteTransactionHandler(TransactionDbContext context) : IRequestHandler<DeleteTransactionCommand>
{
    public async Task Handle(DeleteTransactionCommand request, CancellationToken cancellationToken)
    {
        var transaction = await context.Transactions.FindAsync([request.Id], cancellationToken);

        if (transaction is null) 
            return;
        
        context.Transactions.Remove(transaction);
        await context.SaveChangesAsync(cancellationToken);
    }
}