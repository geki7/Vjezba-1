using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mjenjacnica.Models;

namespace Mjenjacnica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite iznos u HRK: ");
            double unosTecaj = double.Parse(Console.ReadLine());
            Console.WriteLine("Odaberite valutu: ");
            string valuta = Console.ReadLine();

        }
    }
}
