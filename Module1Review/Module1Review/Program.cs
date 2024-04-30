namespace Module1Review
{
    internal class Program
    {
      public static double CircleAreaCalculation(double radius)
        {
            return 3.1415 * (radius * radius);
        }
        
        
        
        
        
        
        
        
        static void Main(string[] args)
        {
            double circleArea = CircleAreaCalculation(4);

            Console.WriteLine(circleArea);

        }
    }

}
