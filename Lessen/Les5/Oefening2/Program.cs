using System;

namespace Oefening2
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Hello World!");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + " x " + getal +" = "  + i*getal);
            }
        }
    }
}
