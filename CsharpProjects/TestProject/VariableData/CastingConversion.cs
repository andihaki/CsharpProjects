using System.Globalization;
using System.Net;

namespace TestProject.VariableData;

class CastingConversion
{
    public static void Run()
    {
        // US dot decimal separator
        CultureInfo.CurrentCulture = new CultureInfo("en-US");
        Exercise2();

        float asdf = 4.123456789f;
        int x = (int)asdf;
    }

    public static void Exercise2()
    {
        int value1 = 11;
        decimal value2 = 6.2m;
        float value3 = 4.3f;

        int result1 = Convert.ToInt32(value1 / value2);
        // Hint: You need to round the result to nearest integer (don't just truncate)
        Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

        // Your code here to set result2
        decimal result2 = value2 / (decimal)value3;
        Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

        // Your code here to set result3
        float result3 = value3 / value1;
        Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
    }

    public static void Exercise()
    {
        string[] values = ["12.3", "45", "ABC", "11", "DEF"];
        string message = "";
        decimal sum = 0;

        foreach (string value in values)
        {
            if (decimal.TryParse(value, out decimal number))
            {
                sum += number;
            }
            else
            {
                message += value;
            }
        }

        Console.WriteLine("Message: " + message);
        Console.WriteLine($"Total: {sum}");
    }

    public static void Conversion()
    {
        int first = 2;
        string second = "4";
        string result = first + second;
        Console.WriteLine(result);

        // widening conversion
        // int myInt = 3;
        // decimal myDecimal = myInt;
        // Console.WriteLine($"int: {myInt}");
        // Console.WriteLine($"decimal: {myDecimal}");

        // casting / narrowing conversion
        // decimal myDecimal = 3.14m;
        // int myInt = (int)myDecimal;
        // Console.WriteLine($"decimal: {myDecimal}");
        // Console.WriteLine($"int: {myInt}");

        // // casting / narrowing conversion
        // decimal myDecimal = 1.23456789m;
        // Console.WriteLine($"Decimal: {myDecimal}");
        // float myFloat = (float)myDecimal;
        // Console.WriteLine($"Float  : {myFloat}");

        // casting = Math.floor. converting = Math.round
        int value = (int)1.9m; // casting truncates = 1 
        int value2 = Convert.ToInt32(1.5m); // converting rounds up = 2
        Console.WriteLine(value);
        Console.WriteLine(value2);
    }


}