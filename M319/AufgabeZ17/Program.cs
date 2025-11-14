using System;

namespace AufgabeZ17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playing = true;

            Console.WriteLine("Willkommen zum Zahlenratespiel!");

            while (playing)
            {
                int randomNumber = random.Next(1, 101);
                int guessedNumber = 0;

                while (randomNumber != guessedNumber)
                {
                    Console.Write("Bitte geben Sie eine Zahl zwischen 1 und 100 ein: ");
                    guessedNumber = Convert.ToInt32(Console.ReadLine());

                    if (guessedNumber > randomNumber)
                    {
                        Console.WriteLine("Die gesuchte Zahl ist kleiner.");
                    }
                    else if (guessedNumber < randomNumber)
                    {
                        Console.WriteLine("Die gesuchte Zahl ist grösser.");
                    }
                    else
                    {
                        Console.WriteLine("Herzlichen Glückwunsch! Sie haben die Zahl erraten!");
                    }
                }

                Console.Write("Möchten Sie noch eine Runde spielen? (j/n): ");
                string antwort = Console.ReadLine().ToLower();

                if (antwort != "j")
                {
                    playing = false;
                }
            }

            Console.WriteLine("Danke fürs Spielen! Auf Wiedersehen!");
        }
    }
}
