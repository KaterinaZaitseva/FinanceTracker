using MediatR;
using Microsoft.AspNetCore.Mvc;
using TransactionService.Application.Features.Transactions.Update;

namespace TransactionService.Presentation.Endpoints.Transactions;

public class Update : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPut("transactions/{id:guid}", 
            async (Guid id, [FromBody] UpdateTransactionCommand request, ISender sender) =>
            {
                var command = request with { Id = id };
                
                await sender.Send(command);
                return TypedResults.Ok();
            });
    }
}