using System;

namespace Opgave03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Play();

            Console.ReadKey();
        }

        public static void Play()
        {
            Console.WriteLine("Velkommen til slå ingen enere!");

            Console.WriteLine("Hvor mange spillere vil du gerne tilføje?");
            int numPlayers = int.Parse(Console.ReadLine());

            Player[] players = new Player[numPlayers];

            for (int i = 0; i < numPlayers; i++)
            {
                Console.WriteLine("Indtast navnet på spiller " + (i + 1) + ":");
                string name = Console.ReadLine();
                players[i] = new Player(name, 69420);
            }

            Random random = new Random();

            foreach (Player player in players)
            {
                Console.WriteLine("\nDet er " + player.Name + "'s tur.");
                Console.WriteLine("Tryk på en tast for at slå med terningen...");
                Console.ReadKey();

                int score = 0;

                while (true)
                {

                    int roll = random.Next(1, 7);

                    if (roll != 1)
                    {
                        score += roll;
                    }
                    else
                    {
                        score = 0;
                        Console.WriteLine("Øv, du slog en 1'er! Din score er nulstillet.");
                        break;
                    }

                    Console.WriteLine("Din score er nu: " + score);

                    Console.WriteLine("Vil du fortsætte? (ja/nej)");
                    string choice = Console.ReadLine().ToLower();

                    if (choice != "ja")
                    {
                        break;
                    }
                }

                player.Score = score;
            }

            Console.WriteLine("\nSlutresultater:");
            foreach (Player player in players)
            {
                Console.WriteLine(player.Name + ": " + player.Score);
            }
        }
    }
}