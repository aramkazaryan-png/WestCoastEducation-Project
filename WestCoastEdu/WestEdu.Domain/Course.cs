using System;

public class Kurs
{
    public string Title { get; set; }
    public string Kursnummer { get; set; }
    public int Langd { get; set; }
    public DateTime Startdatum { get; set; }
    public DateTime Slutdatum { get; set; }
    public bool Klassrum { get; set; }

    public Kurs(string title, string kursnummer, int langd, DateTime startdatum, DateTime slutdatum, bool klassrum)
    {
        Title = title;
        Kursnummer = kursnummer;
        Langd = langd;
        Startdatum = startdatum;
        Slutdatum = slutdatum;
        Klassrum = klassrum;
    }

    public string Presentera()
    {
        string typ = Klassrum ? "Klassrumsbaserad" : "Distans";
        return $"{Title} ({Kursnummer}) - {Langd} veckor, Start: {Startdatum.ToShortDateString()}, Slut: {Slutdatum.ToShortDateString()}, Typ: {typ}";
    }
}