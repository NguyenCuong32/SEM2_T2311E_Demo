using Practice_02;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Square square = new Square(20);
        System.Console.WriteLine($"Area: {square.Area()}");
    }
}