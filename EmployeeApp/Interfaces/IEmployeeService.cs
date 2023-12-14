using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Interfaces
{
    public interface IEmployeeService
    {
        void ShowMeny();
        void AddEmployee();
        void DeleteEmployee();
        void UpdateEmployee();
        void GetEmployee();

        void ShowAllEmployess();
    }
}
