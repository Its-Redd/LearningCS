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
                Console.WriteLine("Vælg en mulighed:");
                Console.WriteLine("1. Spil 500");
                Console.WriteLine("2. Bowling");
                Console.WriteLine("3. Option 3");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Du valgte Spil 500");
                        Console.Write("Hvor mange deltagere vil du indtaste (maksimalt 10): ");
                        if (int.TryParse(Console.ReadLine(), out int numberOfParticipants500) &&
                            numberOfParticipants500 > 0 && numberOfParticipants500 <= 10)
                        {
                            string[] participantNames500 = program.GetPlayerNames(numberOfParticipants500);

                            Console.WriteLine("Deltagernavne:");
                            foreach (string name in participantNames500)
                            {
                                Console.WriteLine(name);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ugyldigt antal deltagere. Programmet afsluttes.");
                        }
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Du valgte Bowling\n");
                        Console.Write("Hvor mangler deltagere var der: ");
                        int.TryParse(Console.ReadLine(), out int input1);



                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("You selected Option 3");
                        // Add your logic for Option 3 here
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Exiting the program. Goodbye!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
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

        public string[] GetPlayerNamesBowling(int numberOfParticipantsBowling)
        {
            string[] participantNames = new string[numberOfParticipantsBowling];

            for (int i = 0; i < numberOfParticipantsBowling; i++)
            {
                Console.Write($"Indtast navn på spiller {i + 1}: ");
                participantNames[i] = Console.ReadLine();
            }

            return participantNames;
        }


    }
}
