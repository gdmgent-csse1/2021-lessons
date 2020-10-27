using System;
using System.IO;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter("output.txt"))
            {
                //Console.WriteLine("Hello World!");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("Tafel van " + j + ":");    
                    outputFile.WriteLine("Tafel van " + j + ":");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine(i + " x " + j +" = "  + i*j);    
                        outputFile.WriteLine(i + " x " + j +" = "  + i*j);   
                    }
                }
            }
        }
    }
}
