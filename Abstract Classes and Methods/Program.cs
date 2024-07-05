// See https://aka.ms/new-console-template for more information
using System;

// Abstract base class
abstract class Shape
{
    public abstract double GetArea();
}

// Derived class Circle
class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

// Derived class Rectangle
class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double GetArea()
    {
        return width * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Abstract Classes and Methods Example");

        // Create instances of Circle and Rectangle
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);

        // Display areas
        Console.WriteLine($"Area of Circle with radius 5: {circle.GetArea():F2}");
        Console.WriteLine($"Area of Rectangle with width 4 and height 6: {rectangle.GetArea():F2}");
    }
}