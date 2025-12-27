using MediatR;
using Microsoft.AspNetCore.Mvc;
using TransactionService.Application.Features.Transactions.Update;

namespace TransactionService.Presentation.Endpoints.Categories;

public class Update : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPut("categories/{id:guid}", 
            async (Guid id, [FromBody] UpdateCategoryCommand request, ISender sender) =>
            {
                var command = request with { Id = id };
                
                await sender.Send(command);
                return TypedResults.Ok();
            });
    }
}