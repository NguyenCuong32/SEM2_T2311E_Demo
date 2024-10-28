using Practice_01;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Square square = new Square();
        square.Side = 10;
        System.Console.WriteLine(square.Area());
        System.Console.WriteLine(square.Perimeter());
        Rectangle rectangle = new Rectangle(10,40);
        System.Console.WriteLine(rectangle.Area());
    }
}