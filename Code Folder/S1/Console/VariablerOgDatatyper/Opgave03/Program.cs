using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = "Pære";
            Console.WriteLine(fruit);

            fruit = "Banan";
            Console.WriteLine(fruit);



            //Spacing 
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            // 1.
            string firstName = "Simon";
            string lastName = " Rasmussen";

            // 2.
            Console.WriteLine(firstName + lastName);

            //3
            Console.WriteLine($"{firstName}{lastName}");

            //4
            string format = String.Format("{0} {1}", firstName, lastName);
            Console.WriteLine(format);
            Console.WriteLine();
            Console.WriteLine() ;

            //5
            string opgaveTekst = "I C# er \"string\" en datatype, der bruges til at repræsentere en sekvens af tegn. En \"string\" i C# er en reference type, hvilket betyder, at den er baseret på en objektreference snarere end at være en værditype som \"int\" eller \"float\". Strenge i C# er uundgåeligt en vigtig del af mange programmer, da de bruges til at håndtere tekst og karakterdata. C# tilbyder også en række nyttige metoder og egenskaber til at arbejde med strenge, såsom at finde længden af en streng, ændre tegn i en streng, opdele en streng i substrings, og meget mere.";

            //6
            Console.WriteLine(opgaveTekst);
            Console.WriteLine();

            //7
            Console.WriteLine(opgaveTekst.ToUpper());
            Console.WriteLine();

            //8
            Console.WriteLine(opgaveTekst.ToLower());
            Console.WriteLine();

            //9 aka way 1 to count
            Console.WriteLine($"Char count: {opgaveTekst.Count()}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();






            //10 + 11
            string temp = opgaveTekst.Replace(" ", "¤");
            Console.WriteLine(temp);

            //12
            int tempFirst = temp.IndexOf("¤");
            Console.WriteLine($"First ¤ occurence at char: {tempFirst}");

            int tempLast = temp.LastIndexOf("¤");
            Console.WriteLine($"Lst ¤ occurence at char: {tempLast}");
            Console.WriteLine();
            Console.WriteLine();

            //13 aka way 2 to count
            Console.WriteLine(opgaveTekst.Length);
            Console.WriteLine();

            //14
            int opgFirst = opgaveTekst.IndexOf(" at "); //Value: 44
            string substringOne = opgaveTekst.Substring(opgFirst, opgaveTekst.Length - 44);
            int opgSecond = substringOne.IndexOf(" at", 4); // Value: 92
            Console.WriteLine($"First occurence: {opgFirst}");
            Console.WriteLine($"Second occurrence: {opgSecond}");

            //15
            string substring = opgaveTekst.Substring(opgFirst, opgSecond);
            Console.WriteLine(substring);





















            // Readline
            Console.ReadLine();
        }
    }
}
