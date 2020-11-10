using System;

namespace oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Shape sh1 = new Shape();
            sh1.LogOutput();
            Rectangle r1 = new Rectangle();
            r1.LogOutput();
            r1.LogOutput("test2");
        }
    }
}
