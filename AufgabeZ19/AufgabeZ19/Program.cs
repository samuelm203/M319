using System;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main(string[] args)
    {
        string userPassword;

        Console.WriteLine("Gib dein Passwort ein: ");
        userPassword = Console.ReadLine();

        IsPasswordGood(userPassword);

        if (IsPasswordGood(userPassword))
        {
            Console.WriteLine("Du hast ein gutes Passwort"); 
        } else
        {
            Console.WriteLine("Dein Passwort ist nicht gut"); 
        }

    }

    static bool IsPasswordGood(string userPassword)
    {
        if (userPassword.Length < 8)
        {
            return false;
        }

        bool hasDigit = false;
        bool hasUpper = false;

        Regex regexSpecialChar = new Regex("[!§\\$%&/()=?@#*\\+\\.,;:\\-_<>{}\\[\\]\\^~|]");
        bool hasSpecialChar = regexSpecialChar.IsMatch(userPassword);

        foreach (char c in userPassword)
        {
            if (Char.IsDigit(c))
            {
                hasDigit = true;
            }
            else if (Char.IsUpper(c))
            {
                hasUpper = true;
            }

            if (hasDigit && hasUpper && hasSpecialChar)
            {
                break;
            }
        }

        return hasDigit && hasUpper && hasSpecialChar;
    }
}
