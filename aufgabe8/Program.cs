using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aufgabe8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie den Rechnungsbetrag in Franken ein: ");
            double betrag = Convert.ToDouble(Console.ReadLine());

            double betragWith10tip = betrag * 1.1;
            betragWith10tip = Math.Round(betragWith10tip, 2);

            double betragWith15tip = betrag * 1.15;
            betragWith15tip = Math.Round(betragWith15tip, 2);

            double betragWith20tip = betrag * 1.2;
            betragWith20tip = Math.Round(betragWith20tip, 2);

            Console.WriteLine("Rechnungsbetrag mit 10% Trinkgeld: " + betragWith10tip.ToString("0.00") + " CHF");
            Console.WriteLine("Rechnungsbetrag mit 15% Trinkgeld: " + betragWith15tip.ToString("0.00") + " CHF");
            Console.WriteLine("Rechnungsbetrag mit 20% Trinkgeld: " + betragWith20tip.ToString("0.00") + " CHF");
        }
    }
}
