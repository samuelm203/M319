using System;

class Program
{
    static void Main()
    {
        Console.Write("Bitte geben Sie einen Monat ein (1-12): ");
        int monat = Convert.ToInt32(Console.ReadLine());

        string jahreszeit;

        if (monat < 1 || monat > 12)
        {
            jahreszeit = "Ungültige Eingabe!";
        }
        else if (monat == 12 || monat == 1 || monat == 2)
        {
            jahreszeit = "Winter";
        }
        else if (monat >= 3 && monat <= 5)
        {
            jahreszeit = "Frühling";
        }
        else if (monat >= 6 && monat <= 8)
        {
            jahreszeit = "Sommer";
        }
        else
        {
            jahreszeit = "Herbst";
        }

        Console.WriteLine("Der Monat gehört zur Jahreszeit: " + jahreszeit);
    }
}
