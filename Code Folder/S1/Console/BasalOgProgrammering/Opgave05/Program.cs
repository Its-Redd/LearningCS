using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.5
            double ShoeSize;

            Console.Write("Indtast din skostørrelse: ");
            double.TryParse(Console.ReadLine(), out ShoeSize);

            if (ShoeSize < 38)
            {
                Console.WriteLine("Små fødder");
            }
            else if (ShoeSize >= 38 && ShoeSize <= 45)
            {
                Console.WriteLine("Gennemsnitlige fødder");
            }
            else if (ShoeSize > 45)
            {
                Console.WriteLine("Store plader");
            }
            else
            {
                Console.WriteLine("Det tror jeg ikke på");
            }

            Console.ReadKey();
            Console.Clear();


            //5.7
            double height;
            double dblWeight;
            char gender;

            Console.Write("Indtast din højde i meter: ");
            double.TryParse(Console.ReadLine(), out height);

            Console.Write("Indtast din vægt i kilo: ");
            double.TryParse(Console.ReadLine(), out dblWeight);
            int weight = Convert.ToInt32(dblWeight);

            Console.WriteLine("Indtast dit køn som samfundet vil sige du er (M/K): ");
            char.TryParse(Console.ReadLine(), out gender);

            double BMI = weight / ((height / 100) * (height / 100));
            Console.WriteLine($"BMI: {BMI}");

            if (BMI < 18.5 && BMI > 5)
            {
                Console.WriteLine("Du er undervægtig");
            }
            else if (BMI < 5)
            {
                Console.WriteLine("Du er en mus");
            }
            else if (BMI >= 18.5 && BMI <= 25)
            {
                Console.WriteLine("Du er normalvægtig");
            }
            else if (BMI > 25 && BMI <= 50)
            {
                Console.WriteLine("Du er overvægtig");
            }
            else if (BMI > 50)
            {
                Console.WriteLine("Du er en hval");
            }
            else
            {
                Console.WriteLine("Der er opstået en fejl");
            }



            dontEnd();
        }

        static void dontEnd()
        {
            Console.WriteLine();
            Console.WriteLine("Press anything to close the program...");
            Console.ReadKey();
        }
    }
}
