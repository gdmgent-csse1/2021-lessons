using System;

namespace Oefening5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Input: Kristof Raes
            // Output: krisraes@student.arteveldehs.be
            GenerateLogin("Kristof Raes");
            GeneratePassword();
        }

        static void GenerateLogin(string name)
        {
                string input = name.ToLower();
                string[] split = input.Split(" ", 2);
                string output = "";
                for (int i = 0; i < 2; i++)
                {
                    output += split[i].Substring(0, 4);
                    Console.WriteLine("Result: " + split[i].Substring(0, 4));
                }
                Console.WriteLine("Output: " + output);
        }

        static void GeneratePassword()
        {
            Random rnd = new Random();
            Console.WriteLine("Getal1 :" + rnd.Next(1, 20));
            Console.WriteLine("Getal2 :" + rnd.Next(1, 20));
            Console.WriteLine("Getal3 :" + rnd.Next(1, 20));
            Console.WriteLine("Getal4 :" + rnd.Next(1, 20));

            char c = (char)10;

            Console.WriteLine(c);
        }
    }
}
