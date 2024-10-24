using System;

namespace OOP_demo;

public class Person
{
    public Person()
    {
        System.Console.WriteLine("Init object");
    }
    public Person(string name)
    {
        Name = name;
    }
    public double Weight { get; set; }
    public double Height { get; set; }
    public string Name { get; set; }
    public void Run()
    {
        System.Console.WriteLine($"{Name} can run");
    }
}
