using System;

namespace AliSalmeh.ChallengeWeek3
{
    class Program
    {
        static void Main(string[] args)
        {
            // ChalengeNumber1
            /* Console.WriteLine("Enter side a: ");
            double sideA = Convert.ToDouble(Console.ReadLine());
            double result1 = Math.Pow(sideA, 2);

            Console.WriteLine("Enter side b: ");
            double sideB = Convert.ToDouble(Console.ReadLine());
            double result2 = Math.Pow(sideB, 2);

            Console.WriteLine("Side c is: ");
            double M = result1 + result2;
            double sideC = Math.Sqrt(M);
            Console.WriteLine(sideC); */

            // Refactor
            Console.WriteLine("Enter side a: ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side b: ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            var sideC = Math.Sqrt((Math.Pow(sideA, 2) + Math.Pow(sideB, 2)));
            Console.WriteLine($"The side c is: {sideC}");
        }
    }
}
