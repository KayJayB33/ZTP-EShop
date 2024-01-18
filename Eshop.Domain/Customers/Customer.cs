using Eshop.Domain.Customers.Events;
using Eshop.Domain.Customers.Rules;
using Eshop.Domain.SeedWork;

namespace Eshop.Domain.Shared
{
    public class Customer : Entity, IAggregateRoot
    {
        public Guid Id { get; private set; } 

        public string Name { get; private set; }

        public static Customer Create(string name)
        {
            return Create(Guid.NewGuid(), name);
        }

        public static Customer Create(Guid id, string name)
        {
            CheckRule(new CustomerNameShouldNotBeEmpty(name));
            CheckRule(new CustomerNameShouldContainOnlyLetters(name));

            return new(id, name);
        }

        private Customer(Guid id, string name)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));

            AddDomainEvent(new CustomerCreatedEvent(Id));
        }
    }
}
