using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Square square = new Square("blue", 3.0);
        // Rectangle rectangle = new Rectangle("red", 5.0, 3.0);
        // Circle circle = new Circle("green", 4.0);

        // Console.WriteLine($"Color of square: {square.GetColor()}");
        // Console.WriteLine($"Area of square: {square.GetArea()}");

        // Console.WriteLine($"Color of rectangle: {rectangle.GetColor()}");
        // Console.WriteLine($"Area of rectangle: {rectangle.GetArea()}");

        // Console.WriteLine($"Color of circle: {circle.GetColor()}");
        // Console.WriteLine($"Area of circle: {circle.GetArea()}");

        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Red", 5.0));
        shapes.Add(new Rectangle("Blue", 4.0, 6.0));
        shapes.Add(new Circle("Green", 3.0));

        // let's loop!

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}