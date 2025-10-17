namespace WestCoastEducation
{
    public class Person
    {
        public string Fornamn { get; set; }
        public string Efternamn { get; set; }
        public string Telefon { get; set; }
        public string Personnummer { get; set; }
        public string Adress { get; set; }
        public string Postnummer { get; set; }
        public string Ort { get; set; }

        public Person(string fornamn, string efternamn, string telefon, string personnummer, string adress, string postnummer, string ort)
        {
            Fornamn = fornamn;
            Efternamn = efternamn;
            Telefon = telefon;
            Personnummer = personnummer;
            Adress = adress;
            Postnummer = postnummer;
            Ort = ort;
        }

        public virtual string Presentera()
        {
            return $"{Fornamn} {Efternamn}, {Telefon}, {Adress}, {Postnummer} {Ort}";
        }
    }
}