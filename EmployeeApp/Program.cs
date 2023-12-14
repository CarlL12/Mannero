using EmployeeApp.Interfaces;
using EmployeeApp.Services;

namespace EmployeeApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var employeeService = new EmployeeService();

            employeeService.ShowMeny();
        }
    }
}
