using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();

        Square square = new Square(4, "green");
        shapes.Add(square);

        Rectangle rectangle = new Rectangle(5, 6, "blue");
        shapes.Add(rectangle);

        Circle circle = new Circle(2, "red");
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"Your {shape} has an area of {area} and is the color {color}.");
        }
    }
}