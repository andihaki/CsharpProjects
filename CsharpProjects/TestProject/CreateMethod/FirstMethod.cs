using System;
using System.Globalization;

namespace TestProject.CreateMethod;

class FirstMethod
{
    public static void Run()
    {
        // US dot decimal separator
        // CultureInfo.CurrentCulture = new CultureInfo("en-US");
        CultureInfo.CurrentCulture = new CultureInfo("fr-FR");
        Fortune();
    }

    public static void Fortune()
    {
        Random random = new Random();
        int luck = random.Next(100);

        string[] text = ["You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"];
        string[] good = ["look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"];
        string[] bad = ["fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."];
        string[] neutral = ["appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."];

        TellFortune();

        void TellFortune()
        {
            Console.WriteLine("A fortune teller whispers the following words:");
            string[] fortune = luck > 75 ? good : (luck < 25 ? bad : neutral);
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{text[i]} {fortune[i]} ");
            }
        }
    }

    public static void IPAddress()
    {
        // string ipv4Input = "107.31.1.5";
        // string ipv4Input = "255...255";
        string[] ipv4Input = ["107.31.1.5", "255.0.0.255", "555..0.555", "255...255"];
        string[] ipv4Parts;

        foreach (var ip in ipv4Input)
        {
            ipv4Parts = ip.Split('.');

            if (ValidateLength() && ValidateZeroes() && ValidateRange())
            {
                Console.WriteLine($"{ip} is a valid IPv4 address");
            }
            else
            {
                Console.WriteLine($"{ip} is an invalid IPv4 address");
            }
        }
        bool ValidateLength()
        {
            if (ipv4Parts.Length == 4)
                return true;
            return false;
        }

        bool ValidateZeroes()
        {
            // Check if each IP address number has no leading zeroes
            foreach (var part in ipv4Parts)
            {
                if (part.Length > 1 && part.StartsWith("0"))
                    return false;
            }
            return true;
        }

        bool ValidateRange()
        {
            // Check if each IP address number is in the range 0 - 255
            foreach (var part in ipv4Parts)
            {
                if (int.TryParse(part, out int number))
                {
                    if (number < 0 || number > 255)
                        return false;
                }
                else
                {
                    return false; // Not a valid integer
                }
            }
            return true;
        }
    }

}