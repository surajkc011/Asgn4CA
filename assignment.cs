using System;

class Circle
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetRadius()
    {
        return radius;
    }

    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }

    public bool IsPointInside(double x, double y)
    {
        double distance = Math.Sqrt(x * x + y * y);
        return distance <= radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of circles you want to create: ");
        int numCircles = int.Parse(Console.ReadLine());

        Circle[] circles = new Circle[numCircles];

        for (int i = 0; i < numCircles; i++)
        {
            Console.Write($"Enter the radius of circle {i + 1}: ");
            double radius = double.Parse(Console.ReadLine());
            circles[i] = new Circle(radius);
        }

        Console.WriteLine("\nCircle Information:");
        foreach (var circle in circles)
        {
            Console.WriteLine($"Radius: {circle.GetRadius()}");
            Console.WriteLine($"Area: {circle.CalculateArea()}");
            Console.WriteLine($"Perimeter: {circle.CalculatePerimeter()}\n");
        }

        Console.Write("Enter x-coordinate of a point: ");
        double xCoord = double.Parse(Console.ReadLine());
        Console.Write("Enter y-coordinate of a point: ");
        double yCoord = double.Parse(Console.ReadLine());

        for (int i = 0; i < numCircles; i++)
        {
            bool inside = circles[i].IsPointInside(xCoord, yCoord);
            Console.WriteLine($"Point ({xCoord}, {yCoord}) is {(inside ? "inside" : "outside")} Circle {i + 1}");
        }
    }
}
