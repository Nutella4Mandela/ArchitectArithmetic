using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Rect(1500, 2500));
            Console.WriteLine(Circle(187.5));
            Console.WriteLine(Triangle(500, 750));
            double total = Rect(1500, 2500) + Circle(187.5) + Triangle(500, 750);
            double totalArea = total * 180;
            Console.WriteLine($"My plan costs: {Math.Round(totalArea, 2)} pesos");

            Console.Write("Total Cost: ");
            CalculateTotalCost();
        }

        static double Rect(double length, double width)
        {
            return length * width;
        }
        static double Circle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        static double Triangle(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }

        static void CalculateTotalCost(
          double length = 1500,
          double width = 2500,
          double radius = 187.5,
          double bottom = 500,
          double height = 700)
        {
            Console.WriteLine($"{length * width}\n{Math.PI * Math.Pow(radius, 2)}\n{0.5 * bottom * height}");
        }

    }
}
