using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica.Models
{
    internal class Tecaj
    {
        public string Valuta;
        public double TrenutniTecaj;
        public Tecaj(string valuta, double trenutnitecaj)
        {
            this.Valuta = valuta;
            this.TrenutniTecaj = trenutnitecaj;
        }
    }
}
