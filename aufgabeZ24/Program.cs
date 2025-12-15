using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aufgabeZ24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
                double[] doubleArray = new double[5];

                for (int i = 0; i < doubleArray.Length; i++)
                {
                    Console.Write($"Bitte geben Sie Zahl {i + 1} ein: ");
                    string input = Console.ReadLine();

                    if (double.TryParse(input, out double result))
                    {
                        doubleArray[i] = result;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte eine Zahl eingeben.");
                        i--;
                    }
                }

                double sum = doubleArray.Sum();
                double average = sum / doubleArray.Length;

                average = Math.Round(average, 1);

                Console.WriteLine($"Der Durchschnitt der eingegebenen Werte ist: {average}");
            
        }
    }
}