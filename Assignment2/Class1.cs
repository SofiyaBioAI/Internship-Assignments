using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_ConsoleApp1
{
    public class MenuExample
    {
        public static void RunRepeatedMenu()
        {
            Console.Write("How many times do you want to repeat the calculations? ");
            int totalRepetitions = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= totalRepetitions; i++)
            {
                Console.WriteLine($"\n================ REPETITION {i} of {totalRepetitions} ================");

                Console.Write("Enter first number (a): ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number (b): ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n--- Operator Menu ---");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.Write("Enter your choice (1-4): ");

                int choice = Convert.ToInt32(Console.ReadLine());
                int c;

                switch (choice)
                {
                    case 1:
                        c = a + b;
                        Console.WriteLine($"Result: {a} + {b} = {c}");
                        break;

                    case 2:
                        c = a - b;
                        Console.WriteLine($"Result: {a} - {b} = {c}");
                        break;

                    case 3:
                        c = a * b;
                        Console.WriteLine($"Result: {a} * {b} = {c}");
                        break;

                    case 4:
                        if (b != 0)
                        {
                            c = a / b;
                            Console.WriteLine($"Result: {a} / {b} = {c}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Cannot divide by zero.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid operation choice entered.");
                        break;
                }
            }

            Console.WriteLine("\nAll repetitions completed! Program execution finished.");
        }
    }
}
