using System;

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public double Radius
    {
        get { return this.radius; }
        set { this.radius = value; }
    }


    public override double CalculateArea()
    {
        var a = Math.PI * this.radius * this.radius;
        return a;
    }

    public override double CalculatePerimeter()
    {
        var p = Math.PI * this.radius;
        return p;
    }

    public override string Draw()
    {
        return base.Draw() + "Circle";
    }
}