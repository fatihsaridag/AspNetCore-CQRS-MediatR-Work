using MediatR;

namespace MediatRExample.CQRS.Commands.ProductCommands
{
    public class CreateProductCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }
    }
}
