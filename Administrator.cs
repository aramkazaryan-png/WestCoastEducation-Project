using System;

public class Administrator
{
    public string Fornamn { get; set; }
    public string Efternamn { get; set; }
    public string Telefon { get; set; }
    public string Personnummer { get; set; }
    public string Adress { get; set; }
    public string Postnummer { get; set; }
    public string Ort { get; set; }
    public string Kunskapsomrade { get; set; }
    public DateTime Anstallningsdatum { get; set; }

    public Administrator(string fn, string en, string tel, string pn, string adr, string post, string ort, string omrade, DateTime anstallning)
    {
        Fornamn = fn;
        Efternamn = en;
        Telefon = tel;
        Personnummer = pn;
        Adress = adr;
        Postnummer = post;
        Ort = ort;
        Kunskapsomrade = omrade;
        Anstallningsdatum = anstallning;
    }

    public string Presentera()
    {
        return $"Admin: {Fornamn} {Efternamn}, Område: {Kunskapsomrade}, Anställd sedan: {Anstallningsdatum.ToShortDateString()}";
    }
}