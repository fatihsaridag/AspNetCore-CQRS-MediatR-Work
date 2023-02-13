using MediatR;
using MediatRExample.CQRS.Commands.ProductCommands;

namespace MediatRExample.CQRS.Handlers.ProductHandler
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand,Guid>
    {

        Task<Guid> IRequestHandler<CreateProductCommand, Guid>.Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Guid.NewGuid());
        }
    }
}
