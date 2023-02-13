using MediatR;
using MediatRExample.Models;

namespace MediatRExample.CQRS.Queries.ProductQueries
{
    public class GetAllProductQuery: IRequest<List<GetProductViewModel>>
    {
    }
}
