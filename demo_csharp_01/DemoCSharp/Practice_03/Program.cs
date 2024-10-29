using Practice_03;

internal class Program
{
    private static void Main(string[] args)
    {
        Bird bird = new Bird();
        bird.Fly();
        AirPlane airPlane= new AirPlane();
        airPlane.Fly();
    }
}