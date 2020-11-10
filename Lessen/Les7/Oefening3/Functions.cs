using System;

namespace oefening3
{
    public static class Functions
    {
        public static int GenerateNumber()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0,100);
            return randomNumber;
        }
    }
}