namespace TestProject.VariableData;

class DataTypes
{
    public static void Run()
    {
        ReferenceType();
    }

    /*
    arrays, classes, and strings that has 'new' operator
    
    The string data type is also a reference type. 
    why a new operator wasn't used when declaring a string?
    This is purely a convenience afforded by the designers of C#. 
    Because the string data type is used so frequently.

    array also can used without new
    before: new int[1]
    after: [1]
    
    */
    public static void ReferenceType()
    {
        // value type
        int val_A = 2;
        int val_B = val_A;
        val_B = 5;

        Console.WriteLine("--Value Types--");
        Console.WriteLine($"val_A: {val_A}");
        Console.WriteLine($"val_B: {val_B}");
        /*
        output
        --Value Types--
        val_A: 2
        val_B: 5
        */

        // reference type
        int[] ref_A = [0];
        int[] ref_B = ref_A;
        ref_B[0] = 5;

        Console.WriteLine("--Reference Types--");
        Console.WriteLine($"ref_A[0]: {ref_A[0]}");
        Console.WriteLine($"ref_B[0]: {ref_B[0]}");
        /*
        output
        --Reference Types--
        ref_A[0]: 5
        ref_B[0]: 5
        */
    }

    /*
    float and double values are stored internally in a binary (base 2) format, 
    while decimal is stored in a decimal (base 10) format.

    floating-point types can hold large numbers with precision, 
    their values can be represented using "E notation", 
    which is a form of scientific notation that means "times 10 raised to the power of." 
    So, a value like 5E+2 would be the value 500 because it's the equivalent of 5 * 10^2, or 5 x 102.
    */
    public static void FloatingPoint()
    {
        Console.WriteLine("");
        Console.WriteLine("Floating point types:");
        Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
        Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
        Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

        /*
        output:
        Floating point types:
        float  : -3.402823E+38 to 3.402823E+38 (with ~6-9 digits of precision)
        double : -1.79769313486232E+308 to 1.79769313486232E+308 (with ~15-17 digits of precision)
        decimal: -79228162514264337593543950335 to 79228162514264337593543950335 (with 28-29 digits of precision)
        */
    }

    public static void Integral()
    {
        Console.WriteLine("Signed integral types:");

        Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
        Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
        Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
        Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

        Console.WriteLine("");
        Console.WriteLine("Unsigned integral types:");

        Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
        Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
        Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
        Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
        /*
                ```Output
        Signed integral types:
        sbyte  : -128 to 127
        short  : -32768 to 32767
        int    : -2147483648 to 2147483647
        long   : -9223372036854775808 to 9223372036854775807

        Unsigned integral types:
        byte   : 0 to 255
        ushort : 0 to 65535
        uint   : 0 to 4294967295
        ulong  : 0 to 18446744073709551615
        ```
        */
    }
}