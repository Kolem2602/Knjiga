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
    }
}
