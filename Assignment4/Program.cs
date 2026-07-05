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
            Console.WriteLine("=== Sentence Reverser App ===");

            StringReverser reverser = new StringReverser();

            Console.Write("\nPlease type a sentence: ");
            string userInput = Console.ReadLine();

            string reversedResult = reverser.ReverseSentence(userInput);

            Console.WriteLine("\n--- Results ---");
            Console.WriteLine($"Original: {userInput}");
            Console.WriteLine($"Reversed: {reversedResult}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
