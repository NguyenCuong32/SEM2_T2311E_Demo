using OOP_demo_02;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Demo OOP");
        Car car = new Car();
        car.Run();
        car.StartEngine();

        Bycle2 bycle = new Bycle2();
        bycle.RunBycle();
    }
}