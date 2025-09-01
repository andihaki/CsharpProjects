using System;
using System.Globalization;

namespace TestProject.DebugException;

class Debugger
{
    public static void Run()
    {
        // US dot decimal separator
        // CultureInfo.CurrentCulture = new CultureInfo("en-US");
        Trial();
    }

    static void Trial()
    {
        /*  
        This code instantiates a value and then calls the ChangeValue method
        to update the value. The code then prints the updated value to the console.
        */
        int x = 5;

        x = ChangeValue(x);

        Console.WriteLine(x);

        int ChangeValue(int value)
        {
            value = 10;
            return value;
        }
    }

}