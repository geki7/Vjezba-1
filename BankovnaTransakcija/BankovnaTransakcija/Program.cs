using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovnaTransakcija
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite IBAN platitelja: ");
            string plateitelj = Console.ReadLine();
            Console.Write("Unesite IBAn primatelja: ");
            string primatelj = Console.ReadLine();
            Console.Write("Unesite iznos plaćanja: ");
            string placanje = Console.ReadLine();   

        }
    }
}
