using System;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Paard paard1 = new Paard(4);
            Console.WriteLine(paard1.ToString());
            paard1.AantalPoten = 3;
            Console.WriteLine(paard1.ToString());
        }
    }

    public class Dier
    {
        // Velden
        private int aantalPoten;
        private string naam;

        // Properties
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

        // Constructor
        public Dier(int poten)
        {
            aantalPoten = poten;
        }

        // Methodes
        public void MaakGeluid()
        {
            Console.WriteLine("Geluid dier!");
        }

        public string ToString()
        {
            return String.Format("Dier: \n Poten: {0}", aantalPoten);
        }
    }

    public class Paard : Dier
    {
        // Velden
        private int aantalSokken;

        // Properties
        public int AantalSokken
        {
            get { return aantalSokken; }
            set { aantalSokken = value; }
        }

        // Constructor
        public Paard(int poten) : base (poten)
        {
            
        }


        // Methodes
        

    }

    public class Hond
    {
        public Hond(){}
    }
}
