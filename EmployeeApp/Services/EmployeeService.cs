
using EmployeeApp.Classes;
using EmployeeApp.Interfaces;

namespace EmployeeApp.Services
{
    public class EmployeeService : IEmployeeService
    {
        List<IEmployee> _employees = new List<IEmployee>();
        public void ShowMeny()
        {
            Console.Clear();
            while (true) 
            {
                Console.Clear();
                Console.WriteLine("MENU OPTIONS");
                Console.WriteLine("1. Add employee");
                Console.WriteLine("2. Delete employee");
                Console.WriteLine("3. Get employee");
                Console.WriteLine("4. Update employee");
                Console.WriteLine("5. Show all employess");

                int option = int.Parse(Console.ReadLine()!);

                switch (option)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        DeleteEmployee();
                        break;
                    case 3:
                        GetEmployee();
                        break;
                    case 4:
                        UpdateEmployee();
                        break;
                    case 5:
                        ShowAllEmployess();
                        break;
                }       
            }
        }
        public void AddEmployee()
        {
            Console.Clear();
            Console.Write("Name:");
            string name = Console.ReadLine()!;
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine()!);
            Console.Write("Position:");
            string position = Console.ReadLine()!;
            Employee newEmployee = new Employee(id, name, position);
            _employees.Add(newEmployee);
            Console.Clear();
            Console.WriteLine($"Added employee {name} with id {id} and position {position}");

            Console.WriteLine("Press any key to return to main menu");
            Console.ReadKey();
        }

        public void DeleteEmployee()
        {
            Console.Clear();
            foreach (Employee emp in _employees)
            {
                Console.WriteLine("-------------");
                Console.WriteLine($"ID: {emp.Id}");
                Console.WriteLine($"Name: {emp.Name}");
                Console.WriteLine($"Position: {emp.Position}");
                Console.WriteLine("-------------");
            }
            Console.Write("Write ID of which employee you want to delete: ");
            int idToDelete = int.Parse(Console.ReadLine()!);
            IEmployee employeeToDelete = _employees.Find(emp => emp.Id == idToDelete)!;

            _employees.Remove(employeeToDelete);

            Console.WriteLine("Employee deleted");

            Console.WriteLine("Press any key to return to main menu");
            Console.ReadKey();
        }

        public void GetEmployee()
        {
            Console.Clear();
            Console.Write("Write ID of employee you want to find:");
            int idBook = int.Parse(Console.ReadLine()!);
            IEmployee findEmployee = _employees.Find(emp => emp.Id == idBook)!;

            Console.WriteLine("Found Employee!");
            Console.WriteLine($"Name:{findEmployee.Name}");
            Console.WriteLine($"ID: {findEmployee.Id}");
            Console.WriteLine($"Position: {findEmployee.Position}");

            Console.WriteLine("Press any key to return to main menu");
            Console.ReadKey();

        }

        public void UpdateEmployee()
        {
            Console.Clear();
            Console.Write("Write ID of employee you want to find:");
            int updateEmployee = int.Parse(Console.ReadLine()!);
            IEmployee employeeToUpdate = _employees.Find(emp => emp.Id == updateEmployee)!;

            if (employeeToUpdate != null)
            {
                Console.WriteLine("Found Employee!");
                Console.WriteLine($"Name:{employeeToUpdate.Name}");
                Console.WriteLine($"ID: {employeeToUpdate.Id}");
                Console.WriteLine($"Position: {employeeToUpdate.Position}");

                Console.WriteLine("Enter new details:");

                Console.Write("New name:");
                string newName = Console.ReadLine()!;
                Console.Write("New position:");
                string newPosition = Console.ReadLine()!;

                employeeToUpdate.Name = newName;
                employeeToUpdate.Position = newPosition;

                Console.WriteLine($"Employee with ID {employeeToUpdate.Id} has been updated.");

                Console.WriteLine("Press any key to return to main menu");
                Console.ReadKey();
            }
        }

        public void ShowAllEmployess()
        {
            foreach (Employee emp in _employees)
            {
                Console.WriteLine("-------------");
                Console.WriteLine($"ID: {emp.Id}");
                Console.WriteLine($"Name: {emp.Name}");
                Console.WriteLine($"Position: {emp.Position}");
                Console.WriteLine("-------------");

            }

            Console.WriteLine("Press any key to return to main menu");
            Console.ReadKey();
        }
    }
}
