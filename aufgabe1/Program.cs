using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program 
{
    static void Main(string[] args)
    {
        // Initialisierung von Variablen
        string firstName; 
        string lastName; 
        int age; 

        Console.WriteLine("What is your first name?"); // Vorname abfragen
        firstName = Console.ReadLine(); // Usereingabe wird in Vorname-Variable gespeichert

        Console.WriteLine("What is your last name?"); // Nachname abfragen
        lastName = Console.ReadLine(); // Usereingabe wird in Nachname-Variable gespeichert

        Consoe.WriteLine("How old are you?"); // Alter abfragen
        age = Convert.ToInt32(Console.ReadLine()); // Initialisierung Alter-Variable

        age = age + 1; // Alter um 1 erhöhen

        Console.WriteLine("Hello " + firstName + " " + lastName + ". Bald wirst du " + age ); // Ausgabe der Begrüßung

        Console.ReadKey(); // Konsolenfenster offen halten
    }
}