using System.Globalization;

namespace TestProject.VariableData;

class ArrayOperation
{
    public static void Run()
    {
        // US dot decimal separator
        CultureInfo.CurrentCulture = new CultureInfo("en-US");
        Exercise();
    }

    public static void Exercise()
    {
        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
        string[] orderIds = orderStream.Split(',');

        foreach (string orderId in orderIds)
        {
            string message = orderId.Length != 4 ? "- Error" : "";
            Console.WriteLine($"{orderId} \t{message}");
        }
    }

    public static void SplitJoin()
    {
        string pangram = "The quick brown fox jumps over the lazy dog";
        string[] words = pangram.Split(' ');
        string[] newMessage = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            char[] letters = words[i].ToCharArray();
            Array.Reverse(letters);
            newMessage[i] = new string(letters);
        }

        string result = String.Join(" ", newMessage);
        Console.WriteLine(result);
    }

    public static void ClearResize()
    {

        string[] pallets = ["B14", "A11", "B12", "A13"];
        Console.WriteLine("");

        Array.Clear(pallets, 0, 2);
        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("");
        Array.Resize(ref pallets, 6);
        Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

        pallets[4] = "C01";
        pallets[5] = "C02";

        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        Console.WriteLine("");
        Array.Resize(ref pallets, 3);
        Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }
    }
}