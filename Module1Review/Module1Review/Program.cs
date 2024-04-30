namespace Module1Review
{
    internal class Program
    {
      public static double CircleAreaCalculation(double radius)
        {
            return 3.1415 * (radius * radius);
        }
        
      public static double TriangleAreaCalculation(double baseLength, double height)
        {
            return (height * baseLength) / 2;
        }
        
      public static double RectangleAreaCalculation(double length, double width)
        {
            return length * width;
        }
        
        
        
        
        static void Main(string[] args)
        {
            double rectangleArea = RectangleAreaCalculation(3, 3);

            Console.WriteLine(rectangleArea);

        }
    }

}
