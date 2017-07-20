using System;

public class Rectangle : Shape
{
    private double height;
    private double width;

    public Rectangle(double height,double width)
    {
        this.Height = height;
        this.Width = width;
    }

    public double Width
    {
        get { return this.width; }
        set { this.width = value; }
    }


    public double Height
    {
        get { return this.height; }
        set { this.height = value; }
    }


    public override double CalculateArea()
    {
        var recArea = this.height * this.width;
        return recArea;
    }

    public override double CalculatePerimeter()
    {
        var recPerimeter = this.height * 2 + this.width * 2;
        return recPerimeter;
    }

    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}