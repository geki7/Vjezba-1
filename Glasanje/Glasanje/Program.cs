using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glasanje.Models;

namespace Glasanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GlasackaKutija glasackaKutij = new GlasackaKutija();
            do
            {
                Console.WriteLine("APLIKACIJA ZA GLASANJE");
                Console.WriteLine("----------------------");
                Console.Write("Unesite OIB: ");
                string unosoib = Console.ReadLine();
                Console.Write("Unesite odabir [Z] = Za, [P] = Protiv i [S] = Susdrzan: ");
                string unosodabir = Console.ReadLine().ToUpper();
                glasackaKutij.Glasaj(unosoib, unosodabir);
                glasackaKutij.DohvatiRezultateGlasanja(unosoib);
            }while(true);
        }
    }
}
