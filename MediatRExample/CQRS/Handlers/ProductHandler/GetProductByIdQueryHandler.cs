using MediatR;
using MediatRExample.CQRS.Queries.ProductQueries;
using MediatRExample.Models;

namespace MediatRExample.CQRS.Handlers.ProductHandler
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
    {
        public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            //GET Product from repository 
            var viewModel = new GetProductViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Book"
            };

            return Task.FromResult(viewModel);
        }
    }
}
