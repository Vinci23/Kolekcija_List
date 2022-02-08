using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcijaList
{
    internal class Ucenik
    {
        private string ime, prezime, razred;

        public override string ToString()
        {
            string ispis = this.ime + "\t" + this.prezime + "\t"
                + this.razred;
            return ispis;
        }

        public Ucenik(string ime, string prezime, string razred)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.razred = razred;


        }
        public string Ime { get=> ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }    
        public string Razred { get => razred; set => razred = value; }
    }
}
