using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemainderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Interactive Remainder Calculator ===");

            RemainderCalculator calc = new RemainderCalculator();
            int dividend = GetIntegerFromUser("Enter the dividend (the number to divide): ");
            int divisor = GetIntegerFromUser("Enter the divisor (the number to divide by): ");
            try
            {
              
                int remainder = calc.CalculateWithArithmetic(dividend, divisor);

                Console.WriteLine("\n--- Results ---");
                Console.WriteLine($"Equation: {dividend} / {divisor}");
                Console.WriteLine($"Remainder: {remainder}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"\nMath Error: {ex.Message}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static int GetIntegerFromUser(string prompt)
        {
            int result;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    return result;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a valid whole number.");
                Console.ResetColor();
            }
        }
    }
}