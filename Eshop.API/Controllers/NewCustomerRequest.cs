namespace Eshop.API.Controllers
{
    public class NewCustomerRequest
    {
        public string Name { get; set; }

        public NewCustomerRequest(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}
