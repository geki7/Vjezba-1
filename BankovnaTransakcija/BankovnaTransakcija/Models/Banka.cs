using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovnaTransakcija.Models
{
    public class Banka
    {
        private List<Racun> racuni;

        public Banka()
        {
            racuni = new List<Racun>();
            racuni.Add(new Racun("HR11", 100000));
            racuni.Add(new Racun("HR22", 50000));
            racuni.Add(new Racun("HR33", 12000));
            racuni.Add(new Racun("HR44", 36000));
        }
        private Racun DohvatiRacun(string iban)
        {
            foreach (Racun item in racuni)
            {
                if(iban == item.IBAN)
                {
                    return item;
                }
            }
            return null;
        }
        public Transakcija IzvrsiPlacanje(string ibanPlatitelj, string ibanPrimatelj, double iznos)
        {
            int pronaden = 0;
            foreach(Racun item in racuni)
            {
                if(ibanPrimatelj == item.IBAN || ibanPlatitelj == item.IBAN)
                {

                }
            }
            return null;
        }
    }
}
