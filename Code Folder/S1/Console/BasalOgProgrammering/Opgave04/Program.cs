using System;

namespace Opgave04
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //4.4.3
            Console.Write("Indtast en værdi til din variabel: ");
            int userInput = int.Parse(Console.ReadLine());
            userInput = userInput + 12;
            Console.WriteLine($"Dit tal er nu blevet øget med 12 og har nu værdien {userInput}");



            Console.ReadKey();
            Console.Clear();


            //4.4.4
            int kmTakst = 9;
            int startTakst = 20;


            Console.WriteLine("||| Taxa Prisudregner |||");
            Console.WriteLine("Starttakst = 20,-");
            Console.WriteLine("Kilometerpris = 9,-");

            Console.WriteLine();
            Console.Write("Indtast turens kilometer længde: ");
            double kmAntal = double.Parse(Console.ReadLine());

            double calculated = startTakst + kmTakst * kmAntal;
            Console.WriteLine($"Den samlede pris vil blive cirka: {calculated},-");


            Console.ReadKey();
            Console.Clear();


            //4.5.3
            double numberOne;
            double numberTwo;

            Console.Write("Indtast Tal: ");
            double.TryParse(Console.ReadLine(), out numberOne);

            Console.Write("Indtast Tal: ");
            double.TryParse(Console.ReadLine(), out numberTwo);

            Console.WriteLine($"Summen af {numberOne} og {numberTwo} er {numberOne + numberTwo}");


            Console.ReadKey();
            Console.Clear();


            //4.6
            double doubleAge;
            int year = 2023;

            Console.Write("Hvad er dit navn: ");
            string name = Console.ReadLine();

            Console.Write($"Hej {name}, hvad er din alder: ");
            double.TryParse(Console.ReadLine(), out doubleAge);
            int intAge = Convert.ToInt32(doubleAge);


            Console.Write("Hvad er din hobby: ");
            string hobby = Console.ReadLine();

            Console.Write($"Hvor mange år har du dyrket {hobby}: ");
            int hobbyAge = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hej {name}, din hobby er {hobby}. Du begyndte at dyrke {hobby} i {year - hobbyAge}");
            Console.WriteLine($"i en alder af {intAge - hobbyAge}");

            Console.ReadKey();
            Console.Clear();





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
