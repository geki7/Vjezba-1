using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Models
{
    public class Linija
    {
        public string Polaziste;
        public string Odrediste;
        public int Udaljenost; 
        public Linija(string polaziste, string odrediste, int udaljenost)
        {
            this.Polaziste = polaziste;
            this.Odrediste = odrediste; 
            this.Udaljenost = udaljenost;
        }
    }
    
}
