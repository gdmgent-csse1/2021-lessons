using System;
using System.Collections.Generic;

namespace Oefening3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Persoon persoon1 = new Persoon("Kristof", "Raes", "kristof.raes@arteveldehs.be");
            persoon1.WriteLog();
            persoon1.WriteLog("test");
            Persoon persoon2 = new Persoon("Kris", "Raes", "kris.raes@arteveldehs.be");
            List<Persoon> personen = new List<Persoon>();
            personen.Add(persoon1);
            personen.Add(persoon2);
            
        }
    }
}
