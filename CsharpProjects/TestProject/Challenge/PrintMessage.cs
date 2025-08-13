namespace TestProject.Challenge;

class PrintMessage
{
    public static void Run()
    {
        int firstValue = 500;
        int secondValue = 600;
        int largerValue = System.Math.Max(firstValue, secondValue);
        Console.WriteLine(largerValue);
    }
}
