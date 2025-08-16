using System.Globalization;

namespace TestProject.VariableData;

class StringMethods
{
    public static void Run()
    {
        // US dot decimal separator
        // CultureInfo.CurrentCulture = new CultureInfo("en-US");
        Excercise1();
    }

    public static void Excercise1()
    {
        const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

        string quantity = input.Substring(input.IndexOf("<span>") + 6, input.IndexOf("</span>") - input.IndexOf("<span>") - 6);
        string output = input.Replace("<div>", "")
                             .Replace("</div>", "")
                             .Replace("&trade;", "&reg;");

        // Your work here

        Console.WriteLine(quantity);
        Console.WriteLine(output);
    }

    public static void IndexOfAny()
    {
        string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

        // The IndexOfAny() helper method requires a char array of characters. 
        // You want to look for:

        char[] openSymbols = { '[', '{', '(' };

        // You'll use a slightly different technique for iterating through 
        // the characters in the string. This time, use the closing 
        // position of the previous iteration as the starting index for the 
        // next open symbol. So, you need to initialize the closingPosition 
        // variable to zero:

        int closingPosition = 0;

        while (true)
        {
            int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

            if (openingPosition == -1) break;

            string currentSymbol = message.Substring(openingPosition, 1);

            // Now  find the matching closing symbol
            char matchingSymbol = ' ';

            switch (currentSymbol)
            {
                case "[":
                    matchingSymbol = ']';
                    break;
                case "{":
                    matchingSymbol = '}';
                    break;
                case "(":
                    matchingSymbol = ')';
                    break;
            }

            // To find the closingPosition, use an overload of the IndexOf method to specify 
            // that the search for the matchingSymbol should start at the openingPosition in the string. 

            openingPosition += 1;
            closingPosition = message.IndexOf(matchingSymbol, openingPosition);

            // Finally, use the techniques you've already learned to display the sub-string:

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));
        }
    }
    public static void IndexOfLastIndexOf()
    {
        string message = "(What if) there are (more than) one (set of parentheses)?";
        while (true)
        {
            int openingPosition = message.IndexOf('(');
            if (openingPosition == -1) break;

            openingPosition += 1;
            int closingPosition = message.IndexOf(')');
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            // Note the overload of the Substring to return only the remaining 
            // unprocessed message:
            message = message.Substring(closingPosition + 1);
        }
    }
    public static void IndexOfSubstring()
    {
        string message = "Find what is (inside the parentheses)";

        int openingPosition = message.IndexOf('(');
        int closingPosition = message.IndexOf(')');

        openingPosition += 1;
        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));
    }


}