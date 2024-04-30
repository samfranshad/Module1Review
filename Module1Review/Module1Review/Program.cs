namespace Module1Review
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


        }
    }

}
