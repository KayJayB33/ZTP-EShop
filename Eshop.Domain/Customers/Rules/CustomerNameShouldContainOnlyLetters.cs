using Eshop.Domain.SeedWork;

namespace Eshop.Domain.Customers.Rules
{
    public class CustomerNameShouldContainOnlyLetters : IBusinessRule
    {

        private readonly string _name;

        public CustomerNameShouldContainOnlyLetters(string name)
        {
            _name = name;
        }

        public bool IsBroken() => !_name.All(char.IsLetter);

        public string Message => "Name should contain only letters";
    }
}
