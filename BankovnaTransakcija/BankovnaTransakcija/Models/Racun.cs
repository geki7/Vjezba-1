using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovnaTransakcija.Models
{
    public class Racun
    {
        public string IBAN;
        public double Stanje;

        public Racun(string iban, double stanje)
        {
            this.IBAN = iban;
            this.Stanje = stanje;
        }
    }
}
