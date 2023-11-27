using System;

namespace Opgave08
{
    class Program
    {

        static void Main(string[] args)
        {
            Program program = new Program();


            while (true)
            {

                Console.Clear();
                Console.WriteLine("Du valgte Spil 500");
                Console.Write("Hvor mange deltagere vil du indtaste (maksimalt 10): ");
                if (int.TryParse(Console.ReadLine(), out int numberOfParticipants500) &&
                    numberOfParticipants500 > 0 && numberOfParticipants500 <= 10)
                {
                    string[] participantNames500 = program.GetPlayerNames(numberOfParticipants500);
                    Console.WriteLine("deltagernes Navne");
                    for (int i = 0; i < participantNames500.Length; i++)
                    { Console.WriteLine(participantNames500[i]); }

                    Console.WriteLine("Tryk på en tast for at bekræfte...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Ugyldigt antal deltagere.");
                }
                break;


            }

            Console.WriteLine();
        }

        public string[] GetPlayerNames(int numberOfParticipants)
        {
            string[] participantNames = new string[numberOfParticipants];

            for (int i = 0; i < numberOfParticipants; i++)
            {
                Console.Write($"Indtast navn på spiller {i + 1}: ");
                participantNames[i] = Console.ReadLine();
            }

            return participantNames;
        }
    }
}

