namespace TestProject.Logic;

class DoWhile
{
    public static void Run()
    {
        CodeThree();
    }

    public static void CodeThree()
    {
        string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];
        int periodLocation;

        for (int i = 0; i < myStrings.Length; i++)
        {
            string myString = myStrings[i];
            do
            {
                periodLocation = myString.IndexOf(".");
                Console.WriteLine(myString.Substring(0, periodLocation != -1 ? periodLocation : myString.Length).Trim());
                myString = myString.Substring(periodLocation + 1);
            } while (periodLocation != -1);

            // periodLocation = myString.IndexOf(".");

            // string mySentence;

            // // extract sentences from each string and display them one at a time
            // while (periodLocation != -1)
            // {

            //     // first sentence is the string value to the left of the period location
            //     mySentence = myString.Remove(periodLocation);

            //     // the remainder of myString is the string value to the right of the location
            //     myString = myString.Substring(periodLocation + 1);

            //     // remove any leading white-space from myString
            //     myString = myString.TrimStart();

            //     // update the comma location and increment the counter
            //     periodLocation = myString.IndexOf(".");

            //     Console.WriteLine(mySentence);
            // }

            // mySentence = myString.Trim();
            // Console.WriteLine(mySentence);
        }
    }

    public static void CodeTwo()
    {
        string? readResult;
        bool validEntry = false;
        string[] roles = ["Administrator", "Manager", "User"];
        Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
        do
        {
            readResult = Console.ReadLine();
            if (!roles.Any(role => role.Equals(readResult, StringComparison.InvariantCultureIgnoreCase)))
            {
                Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User)");
            }
            else
            {
                Console.WriteLine($"Your input value ({readResult}) has been accepted.");
                validEntry = true;
            }
        } while (validEntry == false);
    }



    public static void CodeOne()
    {
        string? readResult;
        bool validEntry = false;
        Console.WriteLine("Enter number between 5 and 10!");
        do
        {
            readResult = Console.ReadLine();
            if (readResult != null && int.TryParse(readResult, out int number))
            {
                if (number >= 5 && number <= 10)
                {
                    validEntry = true;
                    Console.WriteLine($"Your input value ({number}) has been accepted.");
                }
                else
                {
                    Console.WriteLine($"You entered {number}. Please enter a number between 5 and 10.");
                }
            }
            else
            {
                Console.WriteLine("Sorry, you entered an invalid number, please try again");
            }
        } while (validEntry == false);
    }
}
