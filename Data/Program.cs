using Data.Models;
using Data.Service;

namespace Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer_1 = new Customer
            {
                FirstName = "calle",
                LastName = "linki",
                Email = "calle@domain.com",
            };
            var customer_2 = new Customer
            {
                FirstName = "Hans",
                LastName = "Mattin-Lassei",
                Email = "hans@domain.com"
            };
            var customerService = new CustomerService();

            customerService.AddCustomerToList(customer_1);
            customerService.AddCustomerToList(customer_2);

        }
    }
}
