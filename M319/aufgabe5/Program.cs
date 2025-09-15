using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        float bodyweightInKilo;
        float heightInMeters; 

        Console.WriteLine("Enter your bodyweight in kilo :");
        bodyweightInKilo = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter your height in meter :");
        heightInMeters = float.Parse(Console.ReadLine());

        //Ausrechnen des BMI
        float bmi = bodyweightInKilo / (heightInMeters * heightInMeters);

        //BMI ausgeben  und auf eine Nachkommastelle runden
        Console.WriteLine("Your BMI is : " + Math.Round(bmi, 1));

        //Zusatz: BMI-Kategorie
        if (bmi < 18.5)
        {
            Console.WriteLine("You are underweight.");
        }
        else if (bmi >= 18.5 && bmi < 25)
        {
            Console.WriteLine("You have a normal weight.");
        }
        else if (bmi >= 25 && bmi < 30)
        {
            Console.WriteLine("You are overweight.");
        }
        else
        {
            Console.WriteLine("You are obese.");
        }
    }

}