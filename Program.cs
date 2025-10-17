using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static List<Kurs> kurs = new List<Kurs>();
    static List<Studerande> studenter = new List<Studerande>();
    static List<Larare> larare = new List<Larare>();
    static List<EduLeader> ledare = new List<EduLeader>();
    static List<Administrator> administrators = new List<Administrator>();
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n --- Kursbokning ---");
            Console.WriteLine("1. Lägg till kurs");
            Console.WriteLine("2. Lägg till student");
            Console.WriteLine("3. Lägg till lärare");
            Console.WriteLine("4. Lägg till utbildningledare");
            Console.WriteLine("5. Lägg till administratör");
            Console.WriteLine("6. Lista kurser ");
            Console.WriteLine("7. Lista studenter");
            Console.WriteLine("0. Avsluta");

        }
    }
}