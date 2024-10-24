using OOP_demo;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("OOP Demo");
        Person person = new Person("Nam")
        {
            Height = 170,
            Weight = 50
        };
        person.Run();
        System.Console.WriteLine(string.Format("Height {0} Weight {1}", person.Height, person.Weight));

        Boy boy = new Boy();
        boy.Run();
    }
}