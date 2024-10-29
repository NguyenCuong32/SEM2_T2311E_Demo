using System;

namespace Practice_02;

public class Square : Geometry
{
    private readonly double side;

    public Square(double side)
    {
        this.side = side;
    }
    public override double Area()
    {
       return Math.Pow(this.side,2);
    }

    public override double Perimeter()
    {
        return 4*this.side;
    }
}
