using MediatR;
using TransactionService.Domain;
using TransactionService.Infrastructure;

namespace TransactionService.Application.Features.Categories.Create;

public class CreateCategoryHandler(TransactionDbContext context) : IRequestHandler<CreateCategoryCommand>
{
    public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = new Category 
        {
            Name = request.Name,
        };
        
        await context.Categories.AddAsync(category, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }
}