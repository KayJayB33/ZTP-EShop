using Eshop.Domain.SeedWork;

namespace Eshop.Domain.Customers.Rules
{
    public class CustomerNameShouldNotBeEmpty : IBusinessRule
    {
        private readonly string _name;

        public CustomerNameShouldNotBeEmpty(string name)
        {
            _name = name;
        }

        public bool IsBroken() => string.IsNullOrEmpty(_name);

        public string Message => "Name should not be empty";
    }
}
