using System;

namespace Oefening3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Resultaat *: " + Multiply(5, 8));
            Console.WriteLine("Resultaat %: " + Modulo(5, 8));
        }

        static int Multiply(int g1, int g2)
        {
            return g1*g2;
        }

        static int Modulo(int g1, int g2)
        {
            return g2%g1;            
        }

        static int Devide(int g1, int g2)
        {
            return g2%g1;            
        }
    }
}
