using MediatR;
using Microsoft.AspNetCore.Mvc;
using TransactionService.Application.Features.Categories.Create;

namespace TransactionService.Presentation.Endpoints.Categories;

public class Create : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("categories/", async ([FromBody] CreateCategoryCommand command, ISender sender) =>
        {
            await sender.Send(command);
            return TypedResults.Ok();
        });
    }
}