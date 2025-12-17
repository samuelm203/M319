using System;

namespace aufgabeZ22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double zwischensumme = Sum();

            Console.WriteLine();
            Console.WriteLine($"Zwischensumme: CHF {zwischensumme}");

            double rabattierteSumme = Rabatt(zwischensumme);

            double gesamtpreis = BerechneMwst(rabattierteSumme);

            Console.WriteLine($"Gesamtpreis (mit MWST) gerundet: CHF {Math.Round(gesamtpreis, 2)}");
        }

        static double Sum()
        {
            double fullPreis = 0.0;

            while (true)
            {
                Console.Write("Preis in CHF eingeben (0 beendet das Programm): ");
                string input = Console.ReadLine();

                if (!double.TryParse(input, out double preis) || preis < 0)
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte eine gültige Zahl eingeben.");
                    continue;
                }

                if (preis == 0)
                {
                    break;
                }

                fullPreis += preis;
            }

            return fullPreis;
        }

        static double Rabatt(double preis)
        {
            double rabatt;

            while (true)
            {
                Console.Write("Rabatt in % eingeben: ");
                string input = Console.ReadLine();

                if (!double.TryParse(input, out rabatt) || rabatt < 0 || rabatt > 100)
                {
                    Console.WriteLine("Ungültiger Rabatt. Bitte Wert zwischen 0 und 100 eingeben.");
                    continue;
                }

                break;
            }

            double rabattBetrag = preis * rabatt / 100;
            double neuerPreis = preis - rabattBetrag;

            Console.WriteLine($"Zwischensumme mit Rabatt: CHF {neuerPreis}");

            return neuerPreis;
        }

        static double BerechneMwst(double preis)
        {
            const double mwst = 0.081;
            return preis * (1 + mwst);
        }
    }
}
