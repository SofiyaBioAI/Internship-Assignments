using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_ConsoleApp4
{
    public class Employee
    {
       
        public int EmployeeId { get; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            EmployeeId = id;
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Name: {Name}");
        }
    }
}
