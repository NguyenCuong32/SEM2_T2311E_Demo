using System;

namespace Practice_02;

public class Rectangle : Geometry
{
    private readonly double width;
    private readonly double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    public override double Area()
    {
        return this.width * this.height;
    }

    public override double Perimeter()
    {
       return 2 * (this.height + this.width);
    }
}
