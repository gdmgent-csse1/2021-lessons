using System;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Paard p1 = new Paard();
            Console.WriteLine(p1.ToString());
        }
    }

    class Dier
    {
        private int aantalPoten;
        private string naam;

        public int AantalPoten
        {
            get { return aantalPoten; }
            set { aantalPoten = value; }
        }

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
        public string Ras
        {
            get;
            set;
        }

        public Dier(){}

        public void MaakGeluid()
        {
            // Maak een geluid...
        }
    }

    class Paard : Dier
    {
        private int aantalSokken;
        public Paard(){}

    }

    class Hond
    {
        public Hond(){}
    }
}
