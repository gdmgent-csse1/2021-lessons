using System;

namespace Oefening2
{
    class Program
    {
        static int getal3;
        static int getal4;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Globale variabelen een startwaarde geven.
            getal3 = 5;
            getal4 = 3;
            //Console.WriteLine("Geef een getal1 in: ");
            //int getal1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Geef een getal2 in: ");
            //int getal2 = Convert.ToInt32(Console.ReadLine());
            // Een vermenigvuldiging met 2 getallen via Console.
            //Vermenigvuldigen(getal1, getal2);
            // Een vermenigvuldiging uitvoeren van 2 getallen die opgeslagen zijn in de lokale variabelen.
            //Vermenigvuldigen();
            // Globale variabelen die we gebruiken.
            //Vermenigvuldigen();
            Console.WriteLine("Geef op van welk getal je de vermenigvuldigingstafel wil zien: ");
            TafelVanX(Convert.ToInt32(Console.ReadLine()));
        }

        // Methode met lokale variabelen.
        /*
        static void Vermenigvuldigen()
        {
            int getal1 = 2;
            int getal2 = 5;
            int resultaat = getal1 * getal2;
            Console.WriteLine(resultaat);
        }
        */

        // Methode met globale variabelen
        static void Vermenigvuldigen()
        {
            int resultaat = getal3 * getal4;
            Console.WriteLine(resultaat);
        }

        static void Vermenigvuldigen(int g1, int g2)
        {
            int resultaat = g1 * g2;
            Console.WriteLine(resultaat);
        }

        static void TafelVanX(int x)
        {
            for(int y = 1; y < 11; y++)
            {
                for (int i = 0; i < 11; i++)
                {
                    //int resultaat = x * i;
                    //Console.WriteLine(i + " x " + x + " = " + resultaat);
                    int resultaat = y * i;
                    Console.WriteLine(i + " x " + y + " = " + resultaat);
                }
            }
        }

    }
}
