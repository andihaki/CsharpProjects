namespace TestProject.Logic;

class BooleanExpression
{
    public static void Run()
    {
        Console.WriteLine("a" == "a");
        Console.WriteLine("a" == "A");
        Console.WriteLine(1 == 2);

        string myValue = "a";
        Console.WriteLine(myValue == "a");

        string value1 = " a";
        string value2 = "A ";
        Console.WriteLine(value1.Trim().Equals(value2.Trim(), StringComparison.CurrentCultureIgnoreCase));

        int saleAmount = 1001;
        int discount = saleAmount > 1000 ? 100 : 50;

        Console.WriteLine($"Discount: {discount}");

        Random random = new Random();
        Console.WriteLine(random.Next(2) == 0 ? "Heads" : "Tails");

        // exercise
        string permission = "Admin|Manager";
        int level = 55;

        var adminRole = "Admin";
        if (!permission.Contains(adminRole))
        {
            Console.WriteLine("You do not have sufficient privileges.");
            return;
        }

        if (adminRole == "Admin")
        {
            if (level > 55)
            {

                Console.WriteLine("Welcome, Super Admin user.");
            }
            else if (level <= 55)
            {
                Console.WriteLine("Welcome, Admin user.");
            }
        }
        else if (adminRole == "Manager")
        {
            if (level >= 20)
            {
                Console.WriteLine("Contact an Admin for access.");
            }
            else if (level < 20)
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }
        }
    }


}
