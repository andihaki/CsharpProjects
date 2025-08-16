using System.Globalization;

namespace TestProject.VariableData;

class Alphanumeric
{
    public static void Run()
    {
        // US dot decimal separator
        // CultureInfo.CurrentCulture = new CultureInfo("en-US");
        CultureInfo.CurrentCulture = new CultureInfo("fr-FR");
        Payment();
    }

    public static void Payment()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US");
        string customerName = "Ms. Barros";

        string currentProduct = "Magic Yield";
        int currentShares = 2975000;
        decimal currentReturn = 0.1275m;
        decimal currentProfit = 55000000.0m;

        string newProduct = "Glorious Future";
        decimal newReturn = 0.13125m;
        decimal newProfit = 63000000.0m;

        string letters = "";
        letters += $"Dear {customerName},\n";
        letters += "As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\n";
        letters += $"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n\n";
        letters += $"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C2}.\n";
        Console.WriteLine(letters);


        Console.WriteLine("Here's a quick comparison:\n");

        string comparisonMessage = "";


        comparisonMessage += $"{currentProduct.PadRight(20)}{currentReturn:P2}   {currentProfit:C2}\n";
        comparisonMessage += $"{newProduct.PadRight(20)}{newReturn:P2}   {newProfit:C2}\n";



        Console.WriteLine(comparisonMessage);
    }

    public static void StringPaddingAlignment()
    {
        string input = "Pad this".PadLeft(12);
        Console.WriteLine(input.PadLeft(12));
        char[] strings = input.ToCharArray();

        for (int i = 0; i < strings.Length; i++)
        {
            Console.WriteLine($"#{i + 1} {strings[i]}");
        }
    }

    public static void Formatting()
    {
        decimal price = 123.45m;
        int discount = 50;
        Console.WriteLine($"Price: {price:C} (Save {discount:C})");

        // N numeric format specifier, default = 3.
        decimal measurement = 123456.78912m;
        Console.WriteLine($"Measurement: {measurement:N4} units");

        // P percentages format, default = 3
        decimal tax = .36785m;
        Console.WriteLine($"Tax rate: {tax:P2}");
    }
}