using System;
using System.Globalization;

namespace TestProject.CreateMethod;

class ZooPlanner
{
    public static void Run()
    {
        // US dot decimal separator
        // CultureInfo.CurrentCulture = new CultureInfo("en-US");
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

        PlanSchoolVisit(pettingZoo, "School A");
        PlanSchoolVisit(pettingZoo, "School B", 3);
        PlanSchoolVisit(pettingZoo, "School C", 2);
    }

    static void PlanSchoolVisit(string[] pets, string schoolName, int groups = 6)
    {
        pets = RandomizeAnimals(pets);
        string[,] group = AssignGroup(pets, groups);
        Console.WriteLine(schoolName);
        PrintGroup(group);
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

    static string[,] AssignGroup(string[] pets, int groups = 6)
    {
        string[,] result = new string[groups, pets.Length / groups];
        int start = 0;

        for (int i = 0; i < groups; i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] = pets[start++];
            }
        }

        return result;
    }

    static void PrintGroup(string[,] groups)
    {
        for (int i = 0; i < groups.GetLength(0); i++)
        {
            Console.Write($"Group {i + 1}: ");
            for (int j = 0; j < groups.GetLength(1); j++)
            {
                Console.Write($"{groups[i, j]}  ");
            }
            Console.WriteLine();
        }
    }

}