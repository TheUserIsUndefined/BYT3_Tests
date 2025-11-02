namespace Figures;

class Program
{
    static void Main(string[] args)
    {
        IShape sphere = new Sphere(5);
        Console.WriteLine("Sphere:");
        Console.WriteLine($"Area: {sphere.CalculateArea():F3}");
        Console.WriteLine($"Volume: {sphere.CalculateVolume():F3}");
        Console.WriteLine();

        IShape cylinder = new Cylinder(3, 7);
        Console.WriteLine("Cylinder:");
        Console.WriteLine($"Area: {cylinder.CalculateArea():F3}");
        Console.WriteLine($"Volume: {cylinder.CalculateVolume():F3}");
        Console.WriteLine();

        IShape rectangle = new Rectangle(4, 8);
        Console.WriteLine("Rectangle:");
        Console.WriteLine($"Area: {rectangle.CalculateArea():F3}");
        
        Console.WriteLine($"Volume: {rectangle.CalculateVolume():F3}");
        Console.WriteLine();

        IShape cube = new Cube(4);
        Console.WriteLine("Cube:");
        Console.WriteLine($"Area: {cube.CalculateArea():F3}");
        Console.WriteLine($"Volume: {cube.CalculateVolume():F3}");
    }
}