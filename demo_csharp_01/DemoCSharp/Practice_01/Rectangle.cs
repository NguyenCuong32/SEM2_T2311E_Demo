using System;

namespace Practice_01;

public class Rectangle : Shape
{
    private readonly double height;
    private readonly double width;

    public Rectangle(double height, double width)
{
        this.height = height;
        this.width = width;
        this.height = height;
    }
    public override double Area()
    {
        return this.height * this.width;
    }

    public override double Perimeter()
    {
        return 2 * (this.height + this.width);
    }
}
