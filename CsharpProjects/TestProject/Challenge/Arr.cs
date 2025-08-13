namespace TestProject.Challenge;

class Arr
{
    public static void Run()
    {
        string[] orders = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

        for (int i = 0; i < orders.Length; i++)
        {
            if (orders[i].StartsWith("B"))
            {
                Console.WriteLine($"Order {orders[i]} is a B order.");
            }
        }
    }


}
