using System;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            // throw new Exception();

            /*
            try
            {
                Console.WriteLine("Hello World!");
                throw new InvalidProgramException();
            }
            catch (System.Exception)
            {
                //throw;
                Console.WriteLine("Probleem opgevangen!");
            }
            */


        try
        {
            Console.WriteLine("Hello World!");
            throw new InvalidProgramException();
        }
        finally
        {
            Console.WriteLine("Is toch in orde");
        }

    
/*
            try
            {
                Console.WriteLine("Hello World!");
                throw new InvalidProgramException();
            }
            finally
            {
                Console.WriteLine("Zeker uitvoeren!");
            }
  */          

            /*
            try
            {
                Console.WriteLine("Hello World!");
                //throw new InvalidProgramException();
                throw new InvalidOperationException();
            }
            catch (InvalidProgramException ipe)
            {
                Console.WriteLine("Invalid Program Exception: " + ipe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Is zeker ook uitgevoerd!");
            }
            */
        }
    }
}
