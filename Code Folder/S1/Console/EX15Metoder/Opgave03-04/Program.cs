using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave03_04
{
    internal class Program
    {
        static void Main()
        {
            int maxNumber = FindMax(10, 15);
            Console.WriteLine(maxNumber);

            string[] names = { "Alice", "Bob", "Charlie" };
            PrintArray(names);

            Console.ReadKey();
        }

        static int FindMax(int a, int b)
        {
            return Math.Max(a, b);
        }

        static void PrintArray(string[] arr)
        {
            foreach (string element in arr)
            {
                Console.WriteLine(element);
            }
        }
    }
}
