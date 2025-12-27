using MediatR;
using TransactionService.Application.Features.Categories.Delete;

namespace TransactionService.Presentation.Endpoints.Categories;

public class Delete : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapDelete("categories/{id:guid}", async (Guid id, ISender sender) =>
        {
            await sender.Send(new DeleteCategoryCommand(id));
            return TypedResults.Ok();
        });
    }
}