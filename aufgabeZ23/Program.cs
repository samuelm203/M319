using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aufgabeZ26
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Unteraufgabe 1
            int[] caseOne = { 1, 2, 3, 5, 2, 32, 231, 325, 23, 10 };

            for (int i = 0; i < caseOne.Length; i++)
            {
                Console.WriteLine(caseOne[i]);
            }

            // Unteraufgabe 2
            Console.WriteLine("-----");

            int[] caseTwo = { 4, 7, 2, 10, 15 };

            Console.WriteLine(caseTwo[4]);

            // Unteraufgabe 3
            Console.WriteLine("-----");
            int[] caseThree = new int[10];

            for (int i = 0; i < caseThree.Length; i++)
            {
                caseThree[i] = i * 2;
                Console.WriteLine("Zahl " + i + ": " + caseThree[i]);
            }

            // Unteraufgabe 4
            Console.WriteLine("-----");

            int [] caseFour = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };

            int sumCaseFour = caseFour.Sum();

            Console.WriteLine("Summe: " + sumCaseFour);

            // Unteraufgabe 5
            Console.WriteLine("-----");

            int[] caseFive = { 5, 10, 15, 2320, 25, 30, 35, 40, 45, 50 };

            int biggestCaseFive = caseFive.Max();

            Console.WriteLine("Grösste Zahl: " + biggestCaseFive);
        }
    }

}