using System;
using System.Globalization;

namespace TestProject.CreateMethod;

class MethodReturn
{
    public static void Run()
    {
        // US dot decimal separator
        // CultureInfo.CurrentCulture = new CultureInfo("en-US");
        DiceGame();
    }

    public static void DiceGame()
    {
        Random random = new Random();

        Console.WriteLine("Would you like to play? (Y/N)");
        if (ShouldPlay())
        {
            PlayGame();
        }

        void PlayGame()
        {
            var play = true;

            while (play)
            {
                var target = GetTarget();
                var roll = RollDice();

                Console.WriteLine($"Roll a number greater than {target} to win!");
                Console.WriteLine($"You rolled a {roll}");
                Console.WriteLine(WinOrLose(roll, target));
                Console.WriteLine("\nPlay again? (Y/N)");

                play = ShouldPlay();
            }
        }

        bool ShouldPlay()
        {
            var input = Console.ReadLine()?.ToUpper();
            return input == "Y";
        }

        int GetTarget()
        {
            return random.Next(1, 6);
        }

        int RollDice()
        {
            return random.Next(1, 7);
        }

        string WinOrLose(int roll, int target)
        {
            return roll > target ? "You win!" : "You lose!";
        }
    }

    public static void ReturnArray2D()
    {
        int target = 30;
        int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
        int[,] result = TwoCoins(coins, target);

        if (result.Length == 0)
        {
            Console.WriteLine("No two coins make change");
            return;
        }

        Console.WriteLine("Change found at positions:");
        for (int i = 0; i < result.GetLength(0); i++)
        {
            if (result[i, 0] == -1)
            {
                break;
            }
            Console.WriteLine($"{result[i, 0]},{result[i, 1]}");
        }


        static int[,] TwoCoins(int[] coins, int target)
        {
            var results = new List<(int, int)>();

            // Find all possible pairs
            for (int i = 0; i < coins.Length; i++)
            {
                for (int j = i + 1; j < coins.Length; j++)
                {
                    if (coins[i] + coins[j] == target)
                    {
                        results.Add((i, j));
                    }
                }
            }

            // Convert results to 2D array
            if (results.Count == 0)
                return new int[0, 0];

            var resultArray = new int[results.Count, 2];
            for (int i = 0; i < results.Count; i++)
            {
                resultArray[i, 0] = results[i].Item1;
                resultArray[i, 1] = results[i].Item2;
            }

            return resultArray;
        }
    }
    public static void ReturnArray()
    {
        int target = 60;
        int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
        int[] result = TwoCoins(coins, target);
        if (result.Length == 0)
        {
            Console.WriteLine("No two coins make change");
        }
        else
        {
            Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
        }

        static int[] TwoCoins(int[] coins, int target)
        {
            var seen = new Dictionary<int, int>();

            for (int i = 0; i < coins.Length; i++)
            {
                int complement = target - coins[i];

                if (seen.TryGetValue(complement, out int value))
                {
                    return [value, i];
                }

                if (!seen.ContainsKey(coins[i]))
                {
                    seen[coins[i]] = i;
                }
            }

            return new int[0];
        }
    }

    public static void ReturnBoolean()
    {
        string[] words = ["racecar", "talented", "deified", "tent", "tenet"];

        Console.WriteLine("Is it a palindrome?");
        foreach (string word in words)
        {
            Console.WriteLine($"{word.PadRight(10)}: {IsPalindrome(word)}");
        }

        static bool IsPalindrome(string word)
        {
            int start = 0;
            int end = word.Length - 1;

            while (start < end)
            {
                if (!char.Equals(char.ToUpper(word[start]), char.ToUpper(word[end])))
                {
                    return false;
                }
                start++;
                end--;
            }

            return true;
        }
    }

    public static void ReturnString()
    {
        string input = "there are snakes at the zoo";

        Console.WriteLine(input);
        Console.WriteLine(ReverseSentence(input));

        string ReverseWord(string word)
        {
            string result = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                result += word[i];
            }
            return result;
        }

        string ReverseSentence(string input)
        {
            string result = "";
            string[] words = input.Split(" ");

            foreach (string word in words)
            {
                result += ReverseWord(word) + " ";
            }

            return result.Trim();
        }
    }

    public static void ReturnNumber()
    {
        // CultureInfo.CurrentCulture = new CultureInfo("fr-FR");
        double usd = 23.73;
        int vnd = UsdToVnd(usd);

        Console.WriteLine($"${usd} USD = ${vnd} VND");
        Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

        int UsdToVnd(double usd)
        {
            int rate = 23500;
            return (int)(rate * usd);
        }

        double VndToUsd(int vnd)
        {
            double rate = 23500;
            return vnd / rate;

        }
    }

    public static void PurchasePrice()
    {
        double total = 0;
        double minimumSpend = 30.00;

        double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
        double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

        for (int i = 0; i < items.Length; i++)
        {
            total += GetDiscountedPrice(i);
        }

        if (TotalMeetsMinimum())
        {
            total -= 5.00;
        }

        Console.WriteLine($"Total: ${FormatDecimal(total)}");

        double GetDiscountedPrice(int itemIndex)
        {
            return items[itemIndex] * (1 - discounts[itemIndex]);
        }

        bool TotalMeetsMinimum()
        {
            return total >= minimumSpend;
        }

        string FormatDecimal(double input)
        {
            return input.ToString().Substring(0, 5);
        }
    }
}