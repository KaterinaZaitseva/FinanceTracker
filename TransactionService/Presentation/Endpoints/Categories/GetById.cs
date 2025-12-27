using MediatR;
using TransactionService.Application.Features.Categories.GetById;

namespace TransactionService.Presentation.Endpoints.Categories;

public class GetById : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("categories/{id:guid}",
            async (Guid id, ISender sender) =>
            {
                return TypedResults.Ok(await sender.Send(new GetCategoryByIdQuery(id)));
            });
    }
}