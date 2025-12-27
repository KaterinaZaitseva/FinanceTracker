using MediatR;
using TransactionService.Application.Features.Transactions.Update;
using TransactionService.Infrastructure;

namespace TransactionService.Application.Features.Categories.Update;

public class UpdateCategoryHandler(TransactionDbContext context) : IRequestHandler<UpdateCategoryCommand>
{
    public async Task Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = await context.Categories.FindAsync([request.Id], cancellationToken);

        if (category == null)
            return;

        category.Name = request.Name;

        await context.SaveChangesAsync(cancellationToken);
    }
}