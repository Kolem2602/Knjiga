using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Knjiga
    {
        private double cijena;
        private string autor;
        private string naslov;


        public string DohvatiNaslov()
        {
            return naslov;
        }
        public void PostaviNaslov(string naslov)
        {
            this.naslov = naslov;
        }

        public double DohvatiCijenu()
        {
            return cijena;
        }
        public void PostaviCijenu(double cijena)
        {
            this.cijena = cijena;
        }

        public string DohvatiAutor ()
        {
            return autor;
        }
        public void PostaviAutora(string autor)
        {
            this.autor = autor;
        }
        //dohvaca najskuplju knjigu
       public void ispis (List<Knjiga> knjige)
        {
           
            foreach (Knjiga k1 in knjige)
            {
                Console.WriteLine("Naziv knjige: {0}, Autor : {1}, Cijena: {2}", k1.DohvatiNaslov(), k1.DohvatiAutor(), k1.DohvatiCijenu());
            }
         
        }

        public void Najskuplja (List<Knjiga> knjige)
        {
           int br = 0;
            double cj = 0;
            for (int x = 0; x < knjige.Count(); x++)
            {
                Knjiga k1 = knjige.ElementAt(x);
                if (k1.DohvatiCijenu() > cj)
                {
                    cj = k1.DohvatiCijenu();
                    br = x;
                }
            }

            Console.WriteLine("Najskuplja knjiga je {0} i njena cijena je {1}", knjige.ElementAt(br).DohvatiNaslov(), knjige.ElementAt(br).DohvatiCijenu());
        }
    }
}
