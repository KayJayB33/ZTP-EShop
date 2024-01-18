using Eshop.Application.Configuration.Commands;

namespace Eshop.Application.Customers.Commands
{
    public class CreateCustomerCommand : CommandBase<Guid>
    {
        public string Name { get; }

        public CreateCustomerCommand(string name)
        {
            Name = name;
        }
    }
}
