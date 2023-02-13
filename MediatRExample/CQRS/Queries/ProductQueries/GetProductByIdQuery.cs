using MediatR;
using MediatRExample.Models;

namespace MediatRExample.CQRS.Queries.ProductQueries
{
    public class GetProductByIdQuery:IRequest<GetProductViewModel>
    { 
        public Guid Id { get; set; }
    }
}
