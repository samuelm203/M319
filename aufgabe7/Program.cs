using System;

namespace aufgabe7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie den Betrag ein: ");
            double userAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben Sie die Währung ein (EUR, CHF, GBP, USD, JPY): ");
            string userCurrency = Console.ReadLine().ToUpper();

            Console.WriteLine("In welche Währung umrechnen (EUR, CHF, GBP, USD, JPY): ");
            string targetCurrency = Console.ReadLine().ToUpper();

            double result = 0;

            if (userCurrency == "EUR")
            {
                if (targetCurrency == "CHF") result = userAmount * 0.94;
                else if (targetCurrency == "GBP") result = userAmount * 0.83;
                else if (targetCurrency == "USD") result = userAmount * 1.08;
                else if (targetCurrency == "JPY") result = userAmount * 160.0;
                else result = userAmount;
            }
            else if (userCurrency == "CHF")
            {
                if (targetCurrency == "EUR") result = userAmount * 1.06;
                else if (targetCurrency == "GBP") result = userAmount * 0.88;
                else if (targetCurrency == "USD") result = userAmount * 1.15;
                else if (targetCurrency == "JPY") result = userAmount * 170.0;
                else result = userAmount;
            }
            else if (userCurrency == "GBP")
            {
                if (targetCurrency == "EUR") result = userAmount * 1.20;
                else if (targetCurrency == "CHF") result = userAmount * 1.13;
                else if (targetCurrency == "USD") result = userAmount * 1.30;
                else if (targetCurrency == "JPY") result = userAmount * 192.0;
                else result = userAmount;
            }
            else if (userCurrency == "USD")
            {
                if (targetCurrency == "EUR") result = userAmount * 0.92;
                else if (targetCurrency == "CHF") result = userAmount * 0.87;
                else if (targetCurrency == "GBP") result = userAmount * 0.77;
                else if (targetCurrency == "JPY") result = userAmount * 148.0;
                else result = userAmount;
            }
            else if (userCurrency == "JPY")
            {
                if (targetCurrency == "EUR") result = userAmount * 0.0062;
                else if (targetCurrency == "CHF") result = userAmount * 0.0058;
                else if (targetCurrency == "GBP") result = userAmount * 0.0052;
                else if (targetCurrency == "USD") result = userAmount * 0.0067;
                else result = userAmount;
            }

            Console.WriteLine($"{userAmount} {userCurrency} sind {result:F2} {targetCurrency}");
            Console.ReadKey();
        }
    }
}