using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Knjiznica1.Models;

namespace Knjiznica1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite ISBN knjige koju posudujete: ");
            string unosisbn = Console.ReadLine();
            Console.WriteLine("---------------------------------");
            Knjiznica k = new Knjiznica();
            k.Posudi(unosisbn);
            Console.ReadLine();
        }
    }
}
