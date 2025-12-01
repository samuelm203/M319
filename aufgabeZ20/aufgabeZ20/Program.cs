using System;

namespace aufgabeZ20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie heissen Sie?");
            string name = Console.ReadLine();

            greeting(name);
        }

        static string greeting(string name)
        {
            bool isTimeDependent = false;
            int hour = 0;

            Console.WriteLine("Was ist die gewünschte Sprache [de, en, fr]?");
            string language = Console.ReadLine().ToLower();

            if (name == "" || name == null)
            {
                switch (language)
                {
                    case "de":
                        name = "Gast";
                        break;
                    case "en":
                        name = "Guest";
                        break;
                    case "fr":
                        name = "Client";
                        break;
                    default:
                        name = "Gast";
                        language = "de";
                        break;
                }
            }

            Console.WriteLine("Wünschen Sie eine zeitabhängige Begrüssung? (ja/nein)");
            string timeDependent = Console.ReadLine()?.ToLower();

            if (timeDependent == "ja")
            {
                isTimeDependent = true;
                hour = DateTime.Now.Hour;
            }

            switch (language)
            {
                case "de":
                    if (isTimeDependent)
                    {
                        if (hour >= 4 && hour < 12)
                            Console.WriteLine("Guten Morgen " + name);
                        else if (hour >= 12 && hour < 18)
                            Console.WriteLine("Guten Tag " + name);
                        else if (hour >= 18 && hour < 22)
                            Console.WriteLine("Guten Abend " + name);
                        else
                            Console.WriteLine("Gute Nacht " + name);
                    }
                    else
                    {
                        Console.WriteLine("Guten Tag " + name);
                    }
                    break;

                case "fr":
                    if (isTimeDependent)
                    {
                        if (hour >= 4 && hour < 18)
                            Console.WriteLine("Bonjour " + name);
                        else if (hour >= 18 && hour < 22)
                            Console.WriteLine("Bonsoir " + name);
                        else
                            Console.WriteLine("Bonne Nuit " + name);
                    }
                    else
                    {
                        Console.WriteLine("Bonjour " + name);
                    }
                    break;

                case "en":
                    if (isTimeDependent)
                    {
                        if (hour >= 4 && hour < 12)
                            Console.WriteLine("Good morning " + name);
                        else if (hour >= 12 && hour < 18)
                            Console.WriteLine("Hello " + name);
                        else if (hour >= 18 && hour < 22)
                            Console.WriteLine("Good evening " + name);
                        else
                            Console.WriteLine("Good night " + name);
                    }
                    else
                    {
                        Console.WriteLine("Hello " + name);
                    }
                    break;

                default:
                    Console.WriteLine("Guten Tag " + name);
                    break;
            }

            return name;
        }
    }
}
