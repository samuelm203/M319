using System;

internal class Program
{
    static void Main(string[] args)
    {
        uint hours;
        ushort minutes;
        byte seconds;

        float totalHoursInDecimal;

        Console.Write("Gib einen ganzzähligen Zeitwert in Stunden ein: ");
        hours = uint.Parse(Console.ReadLine());

        Console.Write("Gib einen ganzzähligen Zeitwert in Minuten ein: ");
        minutes = ushort.Parse(Console.ReadLine());

        Console.Write("Gib einen ganzzähligen Zeitwert in Sekunden ein: ");
        seconds = byte.Parse(Console.ReadLine());

        float minutesInHours = minutes / 60f;   
        float secondsInHours = seconds / 3600f; 
        float hoursInFloat = hours;

        totalHoursInDecimal = hoursInFloat + minutesInHours + secondsInHours;

        Console.WriteLine("Die Gesamtzeit in Stunden im Dezimalformat beträgt: " + totalHoursInDecimal);
    }
}
