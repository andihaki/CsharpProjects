namespace TestProject.Logic;

class ForLoop
{
    public static void Run()
    {
        // for (int i = 0; i < 10; i++)
        // for (int i = 10; i >= 0; i--)
        for (int i = 1; i <= 100; i++)
        {
            if ((i % 3 == 0) && (i % 5 == 0))
                Console.WriteLine($"{i} - FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine($"{i} - Fizz");
            else if (i % 5 == 0)
                Console.WriteLine($"{i} - Buzz");
            else
                Console.WriteLine($"{i}");
        }


    }
}
