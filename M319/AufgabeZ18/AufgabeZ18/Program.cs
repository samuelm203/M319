using System;

namespace AufgabeZ18
{
    internal class Program
    {
        static void Main()
        {
            decimal userInputOne;
            decimal userInputTwo;
            int userOperation;

            Console.WriteLine("Geben Sie die erste Zahl ein: ");
            userInputOne = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Geben Sie die zweite Zahl ein: ");
            userInputTwo = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Welche Operation soll durchgeführt werden?");
            Console.WriteLine("1 = Addieren");
            Console.WriteLine("2 = Subtrahieren");
            Console.WriteLine("3 = Multiplizieren");
            Console.WriteLine("4 = Dividieren");

            userOperation = Convert.ToInt32(Console.ReadLine());

            if (userOperation > 0 && userOperation < 5)
            {
                decimal result = OperationOfTwoNumbers(userInputOne, userInputTwo, userOperation);
                Console.WriteLine("Das Ergebnis ist: " + result);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe!");
            }
        }

        public static decimal OperationOfTwoNumbers(decimal userInputOne, decimal userInputTwo, int userOperation)
        {
            decimal result = 0;

            switch (userOperation)
            {
                case 1:
                    result = userInputOne + userInputTwo;
                    break;
                case 2:
                    result = userInputOne - userInputTwo;
                    break;
                case 3:
                    result = userInputOne * userInputTwo;
                    break;
                case 4:
                    if (user)
                    result = userInputOne / userInputTwo;
                    break;
                default:
                    Console.WriteLine("Ungültige Operation.");
                    break;
            }

            return result;
        }
    }
}
