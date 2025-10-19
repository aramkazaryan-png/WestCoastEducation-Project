using System;
using System.Collections.Generic;

class Program
{
    static List<Kurs> kurser = new List<Kurs>();
    static List<Studerande> studenter = new List<Studerande>();
    static List<Larare> larare = new List<Larare>();
    static List<EduLeader> ledare = new List<EduLeader>();
    static List<Administrator> administratörer = new List<Administrator>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n--- Kursbokningssystem ---");
            Console.WriteLine("1. Lägg till kurs");
            Console.WriteLine("2. Lägg till student");
            Console.WriteLine("3. Lägg till lärare");
            Console.WriteLine("4. Lägg till utbildningsledare");
            Console.WriteLine("5. Lägg till administratör");
            Console.WriteLine("6. Lista kurser");
            Console.WriteLine("7. Lista studenter");
            Console.WriteLine("0. Avsluta");
            Console.Write("Välj ett alternativ: ");
            string val = Console.ReadLine() ?? "";

            switch (val)
            {
                case "1": LaggaTillKurs(); break;
                case "2": LaggaTillStudent(); break;
                case "3": LaggaTillLarare(); break;
                case "4": LaggaTillLedare(); break;
                case "5": LaggaTillAdministrator(); break;
                case "6": ListaKurser(); break;
                case "7": ListaStudenter(); break;
                case "0": return;
                default: Console.WriteLine("Ogiltigt val."); break;
            }
        }
    }

    static void LaggaTillKurs()
    {
        string title = Console.ReadLine() ?? "";
        Console.Write("Kursnamn: "); title = Console.ReadLine() ?? "";
        Console.Write("Kursnummer: "); string nummer = Console.ReadLine() ?? "";
        Console.Write("Längd i veckor: "); int langd = int.TryParse(Console.ReadLine(), out int tempLangd) ? tempLangd : 0;
        Console.Write("Startdatum (yyyy-mm-dd): "); DateTime start = DateTime.TryParse(Console.ReadLine(), out DateTime tempStart) ? tempStart : DateTime.Today;
        Console.Write("Slutdatum (yyyy-mm-dd): "); DateTime slut = DateTime.TryParse(Console.ReadLine(), out DateTime tempSlut) ? tempSlut : DateTime.Today;
        Console.Write("Klassrum? (ja/nej): "); bool klassrum = (Console.ReadLine() ?? "").ToLower() == "ja";

        kurser.Add(new Kurs(title, nummer, langd, start, slut, klassrum));
        Console.WriteLine("Kurs tillagd!");
    }

    static void LaggaTillStudent()
    {
        Console.Write("Förnamn: "); string fn = Console.ReadLine() ?? "";
        Console.Write("Efternamn: "); string en = Console.ReadLine() ?? "";
        Console.Write("Telefon: "); string tel = Console.ReadLine() ?? "";
        Console.Write("Personnummer: "); string pn = Console.ReadLine() ?? "";
        Console.Write("Adress: "); string adr = Console.ReadLine() ?? "";
        Console.Write("Postnummer: "); string post = Console.ReadLine() ?? "";
        Console.Write("Ort: "); string ort = Console.ReadLine() ?? "";

        studenter.Add(new Studerande(fn, en, tel, pn, adr, post, ort));
        Console.WriteLine("Student tillagd!");
    }

    static void LaggaTillLarare()
    {
        Console.Write("Förnamn: "); string fn = Console.ReadLine() ?? "";
        Console.Write("Efternamn: "); string en = Console.ReadLine() ?? "";
        Console.Write("Telefon: "); string tel = Console.ReadLine() ?? "";
        Console.Write("Personnummer: "); string pn = Console.ReadLine() ?? "";
        Console.Write("Adress: "); string adr = Console.ReadLine() ?? "";
        Console.Write("Postnummer: "); string post = Console.ReadLine() ?? "";
        Console.Write("Ort: "); string ort = Console.ReadLine() ?? "";
        Console.Write("Kunskapsområde: "); string omrade = Console.ReadLine() ?? "";

        larare.Add(new Larare(fn, en, tel, pn, adr, post, ort, omrade));
        Console.WriteLine("Lärare tillagd!");
    }

    static void LaggaTillLedare()
    {
        Console.Write("Förnamn: ");
        string fn = Console.ReadLine() ?? "";
        Console.Write("Efternamn: ");
        string en = Console.ReadLine() ?? "";
        Console.Write("Telefon: ");
        string tel = Console.ReadLine() ?? "";
        Console.Write("Personnummer: ");
        string pn = Console.ReadLine() ?? "";
        Console.Write("Adress: ");
        string adr = Console.ReadLine() ?? "";
        Console.Write("Postnummer: ");
        string post = Console.ReadLine() ?? "";
        Console.Write("Ort: ");
        string ort = Console.ReadLine() ?? "";
        Console.Write("Kunskapsområde: ");
        string omrade = Console.ReadLine() ?? "";
        Console.Write("Anställningsdatum (yyyy-mm-dd): ");
        DateTime anstallning = DateTime.TryParse(Console.ReadLine(), out DateTime temp) ? temp : DateTime.Today;

        ledare.Add(new EduLeader(fn, en, tel, pn, adr, post, ort, omrade, anstallning));
        Console.WriteLine("Utbildningsledare tillagd!");
    }

    static void LaggaTillAdministrator()
    {
        Console.Write("Förnamn: ");
        string fn = Console.ReadLine() ?? "";
        Console.Write("Efternamn: ");
        string en = Console.ReadLine() ?? "";
        Console.Write("Telefon: ");
        string tel = Console.ReadLine() ?? "";
        Console.Write("Personnummer: ");
        string pn = Console.ReadLine() ?? "";
        Console.Write("Adress: ");
        string adr = Console.ReadLine() ?? "";
        Console.Write("Postnummer: ");
        string post = Console.ReadLine() ?? "";
        Console.Write("Ort: ");
        string ort = Console.ReadLine() ?? "";
        Console.Write("Kunskapsområde: ");
        string omrade = Console.ReadLine() ?? "";
        Console.Write("Anställningsdatum (yyyy-mm-dd): ");
        DateTime anstallning = DateTime.TryParse(Console.ReadLine(), out DateTime temp) ? temp : DateTime.Today;

        administratörer.Add(new Administrator(fn, en, tel, pn, adr, post, ort, omrade, anstallning));
        Console.WriteLine("Administratör tillagd!");
    }

    static void ListaKurser()
    {
        Console.WriteLine("\n--- Kurser ---");
        foreach (var k in kurser)
            Console.WriteLine(k.Presentera());
    }

    static void ListaStudenter()
    {
        Console.WriteLine("\n--- Studenter ---");
        foreach (var s in studenter)
            Console.WriteLine(s.Presentera());
    }
}