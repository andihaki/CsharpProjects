using System;
using System.Globalization;

namespace TestProject.CreateMethod;

class ZooPlanner
{
    public static void Run()
    {
        // US dot decimal separator
        CultureInfo.CurrentCulture = new CultureInfo("en-US");
        Planner();
    }

    public static void Planner()
    {
        string[] pettingZoo =
        [
            "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
            "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
            "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises"
        ];

        PrintGroups("School A", AssignGroup(RandomizeAnimals(pettingZoo)));
        PrintGroups("School B", AssignGroup(RandomizeAnimals(pettingZoo), 3));
        PrintGroups("School C", AssignGroup(RandomizeAnimals(pettingZoo), 2));
    }

    static string[,] AssignGroup(string[] pets, int groupCount = 6)
    {
        string[,] groups = new string[groupCount, pets.Length / 2];
        for (int i = 0; i < groupCount; i++)
        {
            groups[i, 0] = $"Group {i + 1}";
            groups[i, 1] = string.Join(", ", pets.Skip(i * pets.Length / groupCount).Take(pets.Length / groupCount));
        }

        return groups;
    }

    static string[] RandomizeAnimals(string[] pets)
    {
        Random random = new Random();

        for (int i = 0; i < pets.Length; i++)
        {
            int r = random.Next(i, pets.Length);
            (pets[i], pets[r]) = (pets[r], pets[i]);
        }
        return pets;
    }

    static void PrintGroups(string schoolName, string[,] groups)
    {
        Console.WriteLine(schoolName);
        for (int i = 0; i < groups.GetLength(0); i++)
        {
            Console.WriteLine($"{groups[i, 0]}: {groups[i, 1]}");
        }
    }

}