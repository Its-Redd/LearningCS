using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave01_02
{
    internal class Program
    {
        static void Main()
        {
            SayHello("Daniel");
            SayGoodbye("Karsten");

            Console.ReadKey();
        }

        static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}! Welcome!");
        }

        static void SayGoodbye(string name)
        {
            Console.WriteLine($"Goodbye, {name}! Take care!");
        }
    }
}
