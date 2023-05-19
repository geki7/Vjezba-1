using Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutobusniKolodvor kolodvor = new AutobusniKolodvor();
            Console.Write("Unesite polaziste, odrediste i tip karte: ");
            string[] unos = Console.ReadLine().Split(' ');
            Console.WriteLine(unos.Length);
            if(unos.Length == 3)
            {
                Console.WriteLine(kolodvor.KupiKartu(unos[0], unos[1], unos[2]));
            }
            if(unos.Length == 4)
            {
                Console.WriteLine(kolodvor.KupiKartu(unos[0], unos[1] + " " + unos[3], unos[4]));
            }
            Console.ReadLine();
        }
    }
}
