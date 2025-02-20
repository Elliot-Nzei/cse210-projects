using System;

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Circle("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 6));
        shapes.Add(new Square("Green", 3));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape: {shape.GetType().Name}, Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
    }
}