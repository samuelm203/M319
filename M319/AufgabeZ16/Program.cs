using System;

namespace Aufgabe16
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Aufgabe 1: Zahlen von 1 bis 10");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            Console.WriteLine("Aufgabe 2: Summe von 1 bis 50");
            int summe = 0;
            for (int i = 1; i <= 50; i++)
            {
                summe += i;
            }
            Console.WriteLine("Summe: " + summe);

            Console.WriteLine();

            Console.WriteLine("Aufgabe 3: Gerade Zahlen zwischen 1 und 100");
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            Console.WriteLine("Aufgabe 4: Countdown von 25 bis 1");
            for (int i = 25; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
        }
    }
}
