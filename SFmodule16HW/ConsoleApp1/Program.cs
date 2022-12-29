using Practices;

internal class Program
{
    private static void Main(string[] args)
    {
        Calculator calculator=new Calculator();
        var a = calculator.Miltiplication(2147483647, 2147483647);

        Console.WriteLine(a);

        a=calculator.Additional(2147483647, 2147483647);
        Console.WriteLine(a);

    }
}