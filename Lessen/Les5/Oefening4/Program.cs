using System;

namespace Oefening4
{
    class Program
    {
        const double Pi = 3.141592653589793;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Area Calculation Circle: " + AreaCalculationCircle(2.52));
            Console.WriteLine("Area Calculation Rectangle: " + AreaCalculationRectangle(5, 3));
        }
        static int AreaCalculationCircle(int r)
        {
            return Convert.ToInt32(r*r*Pi);
        }
        static double AreaCalculationCircle(double r)
        {
            return r*r*Pi;
        }

        static int AreaCalculationRectangle(int b, int h)
        {
            return (b*h)/2;
        }
    }
}
