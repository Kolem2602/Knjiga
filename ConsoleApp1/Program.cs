using ConsoleApp1;
using System;
using System.Collections.Generic;

namespace OsobaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Knjiga k1 = new Knjiga();
            k1.PostaviAutora("Chris Carter");
            k1.PostaviNaslov("Ubojica Crucifix");
            k1.PostaviCijenu(139.28);

            List<Knjiga> Knjige = new List<Knjiga>();
            Knjige.Add(k1);

            Knjiga k2 = new Knjiga();
            k2.PostaviAutora("jfhfh");
            k2.PostaviNaslov("To kill a mockingbird");
            k2.PostaviCijenu(300.18);
            Knjige.Add(k2);

            Knjiga k3 = new Knjiga();
            k3.PostaviAutora("jfhfh");
            k3.PostaviNaslov("Harry Potter");
            k3.PostaviCijenu(186.18);
            Knjige.Add(k3);

            k1.ispis(Knjige);
            k1.Najskuplja(Knjige);





        }
    }
}
