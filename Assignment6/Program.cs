using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee emp = new Employee(101, "John Doe");

            
            emp.Display();

            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}