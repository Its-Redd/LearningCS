using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Opgave06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            
            while (done == false)
            {

                //6.2
                int counter = 1;

                while (counter <= 6)
                {
                    Console.WriteLine("Jeg må ikke lyve");
                    counter++;
                }

                //6.3


                

                
                
            }
















            DoneQuery();
            dontEnd();
        }

        static void DoneQuery()
        {
            bool doneQuery = false;
            while (doneQuery == false)
            {
                Console.WriteLine("\nDo you want to continue (Y/N)");
                string doneOrNot = Console.ReadLine().ToLower();
                if (doneOrNot == "y")
                {
                    done = false;
                    doneQuery = true;
                }
                else if (doneOrNot == "n")
                {
                    done = true;
                    doneQuery = true;
                }
                else
                {
                    doneQuery = false;
                }
            }
        }

        static void dontEnd()
        {
            Console.WriteLine();
            Console.WriteLine("Press anything to close the program...");
            Console.ReadKey();
        }
    }
}
