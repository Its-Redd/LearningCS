using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Variables
            string fullName = "Simon Piihl Rasmussen";

            string adress = "Møllebakken 23";

            string eMail = "61151@edu.campusvejle.dk";

            string path = "C:\\Code Folder\\S1\\Console\\VariablerOgDatatyper\\Opgave01";

            int age = 17;

            int birthYear = 2006;

            int temp = 21;
            DateTime time = new DateTime(2019,03,19, 9, 30, 0);
            string tempTime = $"{temp}C on {time}";

            double promille = 0.3;

            int Percent100 = 100;
            string hundredPercent = $"{Percent100}%";

            int Percent125 = 125;
            string hundredTwentyFivePercent = $"{Percent125}%";

            int Percent25 = 25;
            string twentyFivePercent = $"{Percent25}%";

            int greaterThan0 = 1;


            // Printing

            Console.WriteLine(fullName);

            Console.WriteLine(adress);

            Console.WriteLine(eMail);
            Console.WriteLine();

            Console.WriteLine(path);
            Console.WriteLine();

            Console.WriteLine(age);

            Console.WriteLine(birthYear);
            Console.WriteLine();

            Console.WriteLine(tempTime);
            Console.WriteLine();

            Console.WriteLine(promille);
            Console.WriteLine();

            Console.WriteLine(hundredPercent);

            Console.WriteLine(hundredTwentyFivePercent);

            Console.WriteLine(twentyFivePercent);
            Console.WriteLine();

            Console.WriteLine(greaterThan0);



            Console.ReadLine();
        }
    }
}
