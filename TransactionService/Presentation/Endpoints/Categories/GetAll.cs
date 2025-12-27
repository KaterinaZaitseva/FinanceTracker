using MediatR;
using TransactionService.Application.Features.Categories.GetAll;

namespace TransactionService.Presentation.Endpoints.Categories;

public class GetAll : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("categories/",
            async (ISender sender) =>
            {
                return TypedResults.Ok(await sender.Send(new GetAllCategoriesQuery()));
            });
    }
}