
using Data.Models;
using Newtonsoft.Json;
namespace Data.Service
{
    public class CustomerService
    {
        private readonly FileService _fileService = new FileService(@"D:\CSharpProjects/content.json");
        private List<Customer> _customerList = new List<Customer>();

        public void AddCustomerToList(Customer customer)
        {
            if (! _customerList.Any(x => x.Email == customer.Email))
            {
                _customerList.Add(customer);

                _fileService.SaveContentToFile(JsonConvert.SerializeObject(_customerList));
            }
        }
        public IEnumerable<Customer> GetCustomerFromList()
        {
            var content = _fileService.GetContentFromFile();
            
            if (content != null)
            {
                _customerList = JsonConvert.DeserializeObject<List<Customer>>(content)!;
            }

            return _customerList;
        }
    }
    
}
