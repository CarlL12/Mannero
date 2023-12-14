

using EmployeeApp.Interfaces;

namespace EmployeeApp.Classes
{
    public class Employee : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Position { get; set; } = null!;

        public Employee(int id, string name, string position)
        {
            Id = id;
            Name = name;
            Position = position;

        }
    }
}
