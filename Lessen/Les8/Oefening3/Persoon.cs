using System;

public class Persoon : ILogging
{
    private string naam;
    private string voornaam;
    private string priveMail;
    private List<Adres> adressen;

    public Persoon(string naam, string voornaam, string email, Adres adres)
    {
        this.naam = naam;
        this.voornaam = voornaam;
        this.priveMail = email;
    }

    public void WriteLog()
    {
        Console.WriteLine(this.ToString());
    }

    public void WriteLog(string input)
    {
        Console.WriteLine("Naam: " + this.naam + " " + this.voornaam + ", input: " + input);
    }
}