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

            List<Knjiga> Knjige= new List<Knjiga>();
            Knjige.Add(k1);
        }
    }
}
