

namespace Data.Models
{
    public interface ICustomer
    {
        string Email { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    public class Customer : ICustomer
    {

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;
    }
}
