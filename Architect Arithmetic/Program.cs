using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetRectangleArea(1500, 2500));
            Console.WriteLine(GetCircleArea(375 / 2) / 2);
            Console.WriteLine(GetTriangleArea(750, 500));
            double buildingArea = GetTriangleArea(750, 500) + GetCircleArea(375 / 2) / 2 + GetRectangleArea(1500, 2500);
            double buildingCost = buildingArea * 180;
            Console.WriteLine($"The Teotihuacan will cost {Math.Round(buildingCost, 2)} pesos to build.");
        }
        static double GetRectangleArea(double length, double width)
        {
            double rectangleArea = length * width;
            return rectangleArea;
        }
        static double GetCircleArea(double radius)
        {
            double circleArea = Math.PI * Math.Pow(radius, 2);
            return circleArea;
        }
        static double GetTriangleArea(double bottom, double height)
        {
            double triangleArea = 0.5 * bottom * height;
            return triangleArea;
        }
    }
}
