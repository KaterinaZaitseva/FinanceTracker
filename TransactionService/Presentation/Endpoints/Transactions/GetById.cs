using MediatR;
using TransactionService.Application.Features.Transactions.GetById;

namespace TransactionService.Presentation.Endpoints.Transactions;

public class GetById : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("transactions/{id:guid}",
            async (Guid id, ISender sender) =>
            {
                return TypedResults.Ok(await sender.Send(new GetTransactionByIdQuery(id)));
            });
    }
}