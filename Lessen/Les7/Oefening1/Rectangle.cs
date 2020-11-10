using System;

namespace oefening1
{
    class Rectangle : Shape
    {
        public override void LogOutput()
        {
            Console.WriteLine("Output Rectangle");
        }

        public void LogOutput(string input)
        {
            Console.WriteLine("Output Rectangle - extra info: " + input);
        }

        public string LogOutput(string input, string input2)
        {
            return "Output Rectangle - extra info: " + input;
        }
    }
}