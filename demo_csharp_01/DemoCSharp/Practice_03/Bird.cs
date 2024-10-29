using System;

namespace Practice_03;

public class Bird : IFlyable
{
    public void Fly()
    {
        System.Console.WriteLine("Bird is flying");
    }
}
