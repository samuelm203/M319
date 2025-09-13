using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int stepsPerDay;
        char environment;
        float bankAccountBalance;
        float xAxis;

        Console.Write("How many Steps did you make today? ");
        stepsPerDay = Convert.ToInt32(Console.ReadLine());

        Console.Write("Environmental category? ");
        environment = Convert.ToChar(Console.ReadLine());

        Console.Write("What is your bank account balance? ");
        bankAccountBalance = Convert.ToSingle(Console.ReadLine());

        Console.Write("What is your X axis? ");
        xAxis = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Steps:           " + stepsPerDay);
        Console.WriteLine("Environment:     " + environment);
        Console.WriteLine("Balance:         " + bankAccountBalance);
        Console.WriteLine("X Axis:          " + xAxis);

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}