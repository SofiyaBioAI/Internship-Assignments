using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_ConsoleApp1
{
    public class ConditionalExample
    {
        public static void menu1()
        {
            Console.WriteLine("\n--- Operator Menu ---");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c;

            switch (choice)
            {
                case 1:
                    c = a + b;
                    Console.WriteLine("Result = " + c);
                    break;

                case 2:
                    c = a - b;
                    Console.WriteLine("Result = " + c);
                    break;

                case 3:
                    c = a * b;
                    Console.WriteLine("Result = " + c);
                    break;

                case 4:
                    if (b != 0)
                    {
                        c = a / b;
                        Console.WriteLine("Result = " + c);
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}