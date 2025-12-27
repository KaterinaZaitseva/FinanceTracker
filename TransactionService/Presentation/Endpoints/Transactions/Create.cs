using MediatR;
using Microsoft.AspNetCore.Mvc;
using TransactionService.Application.Features.Transactions.Create;

namespace TransactionService.Presentation.Endpoints.Transactions;

public class Create : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("transactions/", async ([FromBody] CreateTransactionCommand command, ISender sender) =>
        {
            await sender.Send(command);
            return TypedResults.Ok();
        });
    }
}