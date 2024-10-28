using System;

namespace Practice_01;

public class Square : Shape
{
    public double Side { get; set; }
    public override double Area()
    {
        return Math.Pow(Side, 2);
    }

    public override double Perimeter()
    {
        return 4 * Side;
    }
}
