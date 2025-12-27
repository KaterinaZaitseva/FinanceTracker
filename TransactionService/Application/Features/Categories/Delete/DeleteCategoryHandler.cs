using MediatR;
using TransactionService.Infrastructure;

namespace TransactionService.Application.Features.Categories.Delete;

public class DeleteCategoryHandler(TransactionDbContext context) : IRequestHandler<DeleteCategoryCommand>
{
    public async Task Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = await context.Categories.FindAsync([request.Id], cancellationToken);

        if (category is null) 
            return;
        
        context.Categories.Remove(category);
        await context.SaveChangesAsync(cancellationToken);
    }
}