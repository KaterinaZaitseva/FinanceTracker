using MediatR;
using TransactionService.Application.Features.Transactions.Delete;

namespace TransactionService.Presentation.Endpoints.Transactions;

public class Delete : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapDelete("transactions/{id:guid}", async (Guid id, ISender sender) =>
        {
            await sender.Send(new DeleteTransactionCommand(id));
            return TypedResults.Ok();
        });
    }
}