using System;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            string gebruiker = "Kristof";
            Console.WriteLine(gebruiker);
            //string groep = Console.ReadLine();
            //Console.WriteLine("Output: " + groep);
            //Console.WriteLine(groep.Contains('2'));
            //Console.WriteLine(groep.Substring(0, 2));

            int fahrenheit = 100;
            double resultaat = (fahrenheit - 32) * (5.0 / 9.0);
            //double resultaat = 5.0 / 9.0;
            Console.WriteLine(resultaat);
            bool test = true;
            Console.WriteLine(test.ToString());

            fahrenheit++;
            Console.WriteLine(fahrenheit);
            ++fahrenheit;
            Console.WriteLine(fahrenheit);
            fahrenheit += 5;
            Console.WriteLine(fahrenheit);
            Test(fahrenheit);
            
        }

        static void Test()
        {
            Console.WriteLine("Test");
        }


        static int Test(int fah)
        {
            Console.WriteLine("Test " + fah);
            return fah;
        }
    }
}
