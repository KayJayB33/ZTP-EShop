namespace Eshop.Application.Shared
{
    public class CustomerDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public CustomerDto()
        {

        }

        public CustomerDto(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
