using Eshop.Domain.Orders.Events;
using MediatR;

namespace Eshop.Domain.Customers.Events
{
    internal class CustomerCreatedEventHandler : INotificationHandler<CustomerCreatedEvent>
    {
        public Task Handle(CustomerCreatedEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
