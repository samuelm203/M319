using System;

namespace aufgabeZ21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperatur = ReadTemperature();
            string einheit = ReadUnit();

            double result;

            if (einheit == "C")
            {
                result = CelsiusToFahrenheit(temperatur);
                Console.WriteLine($"{temperatur} °C = {result:F2} °F");
            }
            else
            {
                result = FahrenheitToCelsius(temperatur);
                Console.WriteLine($"{temperatur} °F = {result:F2} °C");
            }
        }

        static double ReadTemperature()
        {
            double value;
            while (true)
            {
                Console.Write("Temperatur eingeben: ");
                if (double.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                Console.WriteLine("Ungültige Eingabe. Bitte eine Fliesskommazahl eingeben.");
            }
        }

        static string ReadUnit()
        {
            while (true)
            {
                Console.Write("Einheit eingeben (C für Celsius, F für Fahrenheit): ");
                string input = Console.ReadLine().ToUpper();

                if (input == "C" || input == "F")
                {
                    return input;
                }
                Console.WriteLine("Ungültige Einheit. Bitte C oder F eingeben.");
            }
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}