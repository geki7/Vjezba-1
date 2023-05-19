using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodoviNaVjezbama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string unos = " ";
            do
            {
                Console.WriteLine("1. Dodavanje studenta.");
                Console.WriteLine("2. Dodavanje vjezbe i ocjenjivanje studenta.");
                Console.WriteLine("3. Ispis bodova.");
                Console.WriteLine("4. Izlaz iz programa.");
                Console.Write("Vas odabir je: ");
                unos = Console.ReadLine();
                switch (unos)
                {
                    case "1":
                        {
                            break;
                        }
                    case "2":
                        {
                            break;
                        }
                    case "3":
                        {
                            break;
                        }
                    default:
                        Console.WriteLine("Pogresan unos.");
                        break;
                }
            } while (unos != "4");
        }
    }
}
