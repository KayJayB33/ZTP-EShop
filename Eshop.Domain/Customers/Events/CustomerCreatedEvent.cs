using Eshop.Domain.SeedWork;

namespace Eshop.Domain.Customers.Events
{
    public class CustomerCreatedEvent : DomainEventBase
    {
        public Guid CustomerId { get; }

        public CustomerCreatedEvent(Guid customerId)
        {
            CustomerId = customerId;
        }
    }
}
