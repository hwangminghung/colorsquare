using System;

public interface IColorable
{
    void HowToColor();
}

public class Square : IColorable
{
    public double Side { get; set; }

    public Square(double side)
    {
        Side = side;
    }

    public double Area()
    {
        return Math.Pow(Side, 2);
    }

    public void HowToColor()
    {
        Console.WriteLine("Color all four sides.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IColorable[] shapes = {
            new Square(5),
            // Add other geometric objects here
        };

        foreach (var shape in shapes)
        {
            if (shape is Square)
            {
                Console.WriteLine($"Area: {((Square)shape).Area()}");
            }

            if (shape is IColorable)
            {
                ((IColorable)shape).HowToColor();
            }

            Console.ReadKey();      
        }
    }
}