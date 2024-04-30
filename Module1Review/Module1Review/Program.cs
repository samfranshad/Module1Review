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
        
        
        
        
        
        
        static void Main(string[] args)
        {
            double triangleArea = TriangleAreaCalculation(3, 3);

            Console.WriteLine(triangleArea);

        }
    }

}
