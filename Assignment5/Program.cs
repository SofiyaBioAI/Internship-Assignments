using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixOperations matOps = new MatrixOperations();

            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] array1 = new int[rows, cols];
            int[,] array2 = new int[rows, cols];

            Console.WriteLine("\n--- Enter Elements for Matrix 1 ---");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    array1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\n--- Enter Elements for Matrix 2 ---");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    array2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[,] array3 = matOps.AddMatrices(array1, array2);

            Console.WriteLine("\nMatrix 1:");
            matOps.DisplayMatrix(array1);

            Console.WriteLine("\nMatrix 2:");
            matOps.DisplayMatrix(array2);

            Console.WriteLine("\nSum (Stored in Matrix 3):");
            matOps.DisplayMatrix(array3);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}