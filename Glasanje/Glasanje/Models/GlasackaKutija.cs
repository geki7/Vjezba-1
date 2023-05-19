using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glasanje.Models
{
    public class GlasackaKutija
    {
        private List<Glas> glasovi = new List<Glas>();
        public GlasackaKutija()
        {

        }
        private bool VecGlasao(string oib)
        {
            return glasovi.Find(x => x.OIB == oib) != null ? true : false;
        }
        public void Glasaj(string oib, string odabir)
        {
            if(VecGlasao(oib))
            {
                Console.WriteLine("Vec je glasao.");
            }
            this.glasovi.Add(new Glas(oib, odabir));
        }
        public void DohvatiRezultateGlasanja(string oib)
        {
            int glasoviza = 0;
            int glasoviprotiv = 0;
            int glasovisuzdrzan = 0;
            while (VecGlasao(oib))
            {
                foreach (Glas item in glasovi)
                {
                    switch (item.Odabir)
                    {
                        case "Z":
                            {
                                glasoviza++;
                                break;
                            }
                        case "P":
                            {
                                glasoviprotiv++;
                                break;
                            }
                        case "S":
                            {
                                glasovisuzdrzan++;
                                break;
                            }
                        default:
                            break;
                    }
                }
            }
            Console.WriteLine($"Rezultati glasanja za {glasoviza}, protiv: {glasoviprotiv}, sudrzani: {glasovisuzdrzan}");
        }
    }
}
