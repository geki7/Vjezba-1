using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbornik.Models
{
    public class Film
    {
        public string Naslov;
        public int Godina;
        public List<Glumac> Glumci = new List<Glumac>();
        public static List<Film> Filmovi = new List<Film>();
        public Film(string naslov, int godina)
        {
            this.Naslov = naslov;
            this.Godina = godina;   
            Filmovi.Add(this);
        }
        public void DodajGlumca(Glumac glumac)
        {
            if (Glumci.Contains(glumac))
            {
                Glumci.Add(glumac);
            }
        }
        public string Ispis()
        {
            string retrunMe = "";
            retrunMe = this.Naslov + " - " + this.Godina.ToString() + " (";
            foreach(Glumac item in this.Glumci)
            {
                retrunMe += item.Ispis() + ", ";
            }
            retrunMe += ")";
            return retrunMe;
        }
    }
}
