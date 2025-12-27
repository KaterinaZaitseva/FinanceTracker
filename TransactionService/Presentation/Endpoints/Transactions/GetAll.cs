using MediatR;
using TransactionService.Application.Features.Transactions.GetAll;

namespace TransactionService.Presentation.Endpoints.Transactions;

public class GetAll : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("transactions",
            async (ISender sender) =>
            {
                return TypedResults.Ok(await sender.Send(new GetAllTransactionsQuery()));
            });
    }
}