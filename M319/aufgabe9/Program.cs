using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Geben Sie die erreichte Punktzahl ein");
        int pointsUser = Convert.ToInt32(Console.ReadLine());

        if (pointsUser > 100)
        {
            Console.WriteLine("Die Punktzahl darf nicht über 100 liegen");
        } 
        else if (pointsUser >= 90)
        {
            Console.WriteLine("Sehr gut");
        }
        else if (pointsUser >= 80)
        {
            Console.WriteLine("Gut");
        }
        else if (pointsUser >= 70)
        {
            Console.WriteLine("Befriedigend");
        }
        else if (pointsUser >= 60)
        {
            Console.WriteLine("Ausreichend");
        }
        else if (pointsUser <= 59)
        {
            Console.WriteLine("Nicht bestanden");
        }
        else
        {
            Console.WriteLine("Die Punktzahl darf nicht unter 0 liegen");
        }
    }
}

