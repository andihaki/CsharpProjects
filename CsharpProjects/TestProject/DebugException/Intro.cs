using System;
using System.Globalization;

namespace TestProject.DebugException;

class Intro
{
    public static void Run()
    {
        // US dot decimal separator
        // CultureInfo.CurrentCulture = new CultureInfo("en-US");
        ExceptionHandling();
    }

    /*
    "exception handling" = error on runtime
    */
    static void ExceptionHandling()
    {
        string[] students = new string[] { "Sophia", "Nicolas", "Zahirah", "Jeong" };

        int studentCount = students.Length;

        Console.WriteLine("The final name is: " + students[studentCount]);
    }


}