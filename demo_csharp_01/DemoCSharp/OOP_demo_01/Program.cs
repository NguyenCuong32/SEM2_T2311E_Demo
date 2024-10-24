using OOP_demo_01;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("OOP Demo");
        Person person = new Person();
        person.Eat();
        Dog dog = new Dog();
        dog.Eat();
        Cat cat = new Cat();
        cat.Eat();
    }
}