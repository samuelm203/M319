using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Geben Sie Ihr Alter an: ");
        int ageUser = Convert.ToInt32(Console.ReadLine());

        if (ageUser < 0 || ageUser > 130)
        {
            Console.WriteLine("Ungültiges Alter!");
        }
        else if (ageUser < 6)
        {
            Console.WriteLine("Kein Zutritt zu Kinofilmen.");
        }
        else if (ageUser <= 11)
        {
            Console.WriteLine("Zutritt nur zu Filmen ab 6.");
        }
        else if (ageUser <= 15)
        {
            Console.WriteLine("Zutritt zu Filmen ab 6 und 12.");
        }
        else if (ageUser <= 17)
        {
            Console.WriteLine("Zutritt zu Filmen ab 6, 12 und 16.");
        }
        else
        {
            Console.WriteLine("Zutritt zu allen Filmen (inkl. ab 18).");
        }

        Console.WriteLine("\nDrücken Sie eine Taste, um das Programm zu beenden...");
        Console.ReadKey();
    }
}
