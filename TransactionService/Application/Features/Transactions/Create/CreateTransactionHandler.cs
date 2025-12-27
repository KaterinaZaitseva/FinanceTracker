using MediatR;
using TransactionService.Domain;
using TransactionService.Infrastructure;

namespace TransactionService.Application.Features.Transactions.Create;

public class CreateTransactionHandler(TransactionDbContext context) : IRequestHandler<CreateTransactionCommand>
{
    public async Task Handle(CreateTransactionCommand request, CancellationToken cancellationToken)
    {
        var transaction = new Transaction 
        {
            Amount = request.Amount,
            Type = request.Type,
            CreatedAt = DateTime.UtcNow,
            CategoryId = request.CategoryId,
        };
        
        await context.Transactions.AddAsync(transaction, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }
}