using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        ushort speedInKmH; 
        float distanceInKm;
        float consumptionPer100Km;

        float drivingTimeInMinutes;
        float totalConsumptionInLitersForDrive;

        Console.WriteLine("Wie schnell fähr ein Auto in km/h?");
        speedInKmH = Convert.ToUInt16(Console.ReadLine());

        Console.WriteLine("Was ist die zufahrende Distanz in Kilometer?");
        distanceInKm = float.Parse(Console.ReadLine());

        Console.WriteLine("Wie viel Liter verbraucht das Auto auf 100km?");
        consumptionPer100Km = float.Parse(Console.ReadLine());

        drivingTimeInMinutes = (distanceInKm / speedInKmH) * 60;
        totalConsumptionInLitersForDrive = (consumptionPer100Km / 100) * distanceInKm;

        Console.WriteLine("Die Fahrzeit beträgt " + drivingTimeInMinutes + " Minuten.");
        Console.WriteLine("Der Verbrauch für die Fahrt beträgt " + totalConsumptionInLitersForDrive + " Liter.");
    }
}
