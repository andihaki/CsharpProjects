using System;
using System.Globalization;

namespace TestProject.CreateMethod;

class MethodParameters
{
    public static void Run()
    {
        // US dot decimal separator
        // CultureInfo.CurrentCulture = new CultureInfo("en-US");
        CultureInfo.CurrentCulture = new CultureInfo("fr-FR");
        ChallengeOne();
    }

    public static void ChallengeOne()
    {
        string[,] corporate =
                {
            {"Robert", "Bavin"}, {"Simon", "Bright"},
            {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
            {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
        };

        string[,] external =
                {
            {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
            {"Shay", "Lawrence"}, {"Daren", "Valdes"}
        };

        string externalDomain = "hayworth.com";

        for (int i = 0; i < corporate.GetLength(0); i++)
        {
            Console.WriteLine($"{GetUsername(corporate[i, 0], corporate[i, 1])}@contoso.com");
        }

        for (int i = 0; i < external.GetLength(0); i++)
        {
            Console.WriteLine($"{GetUsername(external[i, 0], external[i, 1])}@{externalDomain}");
        }

        static string GetUsername(string firstName, string lastName)
        {
            return $"{firstName.Substring(2).ToLower()}{lastName.ToLower()}";
        }
    }

    public static void OptionalParameters()
    {
        string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
        string[] rsvps = new string[10];
        int count = 0;

        RSVP("Rebecca");
        RSVP("Nadia", 2, "Nuts");
        RSVP(name: "Linh", partySize: 2, inviteOnly: false);
        RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
        RSVP("Noor", 4, inviteOnly: false);
        RSVP("Jonte", 2, "Stone fruit", false);
        ShowRSVPs();


        void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
        {
            if (inviteOnly)
            {
                bool found = false;
                foreach (string guest in guestList)
                {
                    if (guest.Equals(name))
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine($"Sorry, {name} is not on the guest list");
                    return;
                }
            }

            rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
            count++;
        }

        void ShowRSVPs()
        {
            Console.WriteLine("\nTotal RSVPs:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(rsvps[i]);
            }
        }
    }

    public static void PassByReference()
    {
        int[] array = [1, 2, 3, 4, 5];

        PrintArray(array);
        Array.Clear(array);
        PrintArray(array);

        static void PrintArray(int[] array)
        {
            foreach (int a in array)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine();
        }
    }

    public static void PassByValue()
    {
        int a = 3;
        int b = 4;
        int c = 0;

        Multiply(a, b, c);
        Console.WriteLine($"global statement: {a} x {b} = {c}");

        void Multiply(int a, int b, int c)
        {
            c = a * b;
            Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
        }
    }
}