﻿namespace Module1Review
{
    internal class Program
    {
      public static double CircleAreaCalculation(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        
      public static double TriangleAreaCalculation(double baseLength, double height)
        {
            return (height * baseLength) / 2;
        }
        
      public static double RectangleAreaCalculation(double length, double width)
        {
            return length * width;
        }

      public static double SquareAreaCalculation(double side)
        {
            return side * side;
        }
            

        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius of the circle:");
            double circleRadius = double.Parse(Console.ReadLine());
            double circleArea = CircleAreaCalculation(circleRadius);
            Console.WriteLine($"The area of the circle is {circleArea}");

            Console.WriteLine("Please enter the height of the triangle:");
            double triangleHeight = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the length of the triangle base:");
            double triangleBaseLength = double.Parse(Console.ReadLine());
            double triangleArea = TriangleAreaCalculation(triangleBaseLength, triangleHeight);
            Console.WriteLine($"The area of the triangle is {triangleArea}");

            Console.WriteLine("Please enter the length of the rectangle:");
            double rectangleLength = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the width of the rectangle:");
            double rectangleWidth = double.Parse(Console.ReadLine());
            double rectangleArea = RectangleAreaCalculation(rectangleLength, rectangleWidth);
            Console.WriteLine($"The area of the rectangle is {rectangleArea}");

            Console.WriteLine("Please enter the length of the square side:");
            double squareSide = double.Parse(Console.ReadLine());
            double squareArea = SquareAreaCalculation(squareSide);
            Console.WriteLine($"The area of the square is {squareArea}");

        }
    }

}
