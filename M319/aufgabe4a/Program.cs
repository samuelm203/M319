using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        uint numberFromUser;
        uint numberRoundedIn100;

        byte differenceToValue = 50;

        Console.WriteLine("Geben sie eine ganze Zahl ein, im Bereich von 0 und 100'000");
        numberFromUser = Convert.ToUInt32(Console.ReadLine());

        // Aufrunden auf das nächste Hundert, falls nötig
        numberRoundedIn100 = ((numberFromUser + 50) / 100) * 100;

        Console.WriteLine("Die Zahl gerundet auf Hunderter ist: " + numberRoundedIn100);
    }
}