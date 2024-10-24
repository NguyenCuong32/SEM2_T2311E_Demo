using System;

namespace OOP_demo_02;

public class Car : IVehicle, ICar
{
    public void Run()
    {
        System.Console.WriteLine("Car is runing");
    }

    public void StartEngine()
    {
        System.Console.WriteLine("Engine is started");
    }
}
