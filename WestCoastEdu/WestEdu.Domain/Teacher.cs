using System;
using System.Collections.Generic;

public class Larare
{
    public string Fornamn { get; set; }
    public string Efternamn { get; set; }
    public string Telefon { get; set; }
    public string Personnummer { get; set; }
    public string Adress { get; set; }
    public string Postnummer { get; set; }
    public string Ort { get; set; }
    public string Kunskapsomrade { get; set; }
    public List<Kurs> KurserAnsvarigFor { get; set; } = new List<Kurs>();

    public Larare(string fn, string en, string tel, string pn, string adr, string post, string ort, string omrade)
    {
        Fornamn = fn;
        Efternamn = en;
        Telefon = tel;
        Personnummer = pn;
        Adress = adr;
        Postnummer = post;
        Ort = ort;
        Kunskapsomrade = omrade;
    }

    public string Presentera()
    {
        return $"{Fornamn} {Efternamn}, Område: {Kunskapsomrade}, Kurser ansvarig för: {KurserAnsvarigFor.Count}";
    }

    public void LaggaTillKurs(Kurs kurs)
    {
        KurserAnsvarigFor.Add(kurs);
    }

    public void ListaKurser()
    {
        Console.WriteLine($"Kurser för {Fornamn} {Efternamn}:");
        foreach (var k in KurserAnsvarigFor)
        {
            Console.WriteLine(k.Presentera());
        }
    }
}