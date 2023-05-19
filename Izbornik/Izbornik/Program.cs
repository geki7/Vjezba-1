using Izbornik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izbornik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcija = "";
            do
            {
                Console.Clear();
                Console.WriteLine("1. Dodavanje filma.");
                Console.WriteLine("2. Dodavanje glumaca.");
                Console.WriteLine("3. Ispis svih filmova.");
                Console.WriteLine("4. Ispis svih glumaca.");
                Console.WriteLine("5. Dodavanje glumca u film");
                Console.WriteLine("6. Pretraga filma po glumcu.");
                Console.WriteLine("X. Izlaz iz programa");
                switch (opcija)
                {
                    case "1":
                        {
                            Console.Write("Naslov filma: ");
                            string naslov = Console.ReadLine();
                            Console.Write("Godina filma:");
                            int godina = int.Parse(Console.ReadLine());
                            Film noviFilm = new Film(naslov, godina); 
                            break;
                        }
                    case "2":
                        {
                            Console.Write("Ime glumca: ");
                            string ime = Console.ReadLine();
                            Console.Write("Prezime glumca: ");
                            string prezime = Console.ReadLine();
                            Glumac noviGlumaca = new Glumac(ime, prezime);
                            break;
                        }
                    case "3":
                        {
                            foreach(Film item in Film.Filmovi)
                            {
                                Console.WriteLine(item.Ispis());
                            }
                            break;
                        }
                    case "4":
                        {   
                            foreach(Glumac item in Glumac.Glumci)
                            {
                                Console.WriteLine(item.Ispis());
                            }
                            break;
                        }
                    case "5":
                        {
                            Console.Write("Unesite naziv filma: ");
                            string film = Console.ReadLine();
                            Film trazeniFilm = null;
                            foreach(Film item in Film.Filmovi)
                            {
                                if(item.Naslov.ToLower() == film.ToLower())
                                {
                                    trazeniFilm = item;
                                    break;
                                }
                            }
                            if(trazeniFilm == null)
                            {
                                Console.WriteLine("Filma nema.");
                                break;
                            }
                            Console.Write("Unesite prezime glumca: ");
                            string glumac = Console.ReadLine();
                            Glumac trazeniGlumac = null;
                            foreach(Glumac item in Glumac.Glumci)
                            {
                                if(item.Prezime.ToLower() == glumac.ToLower())
                                {
                                    trazeniGlumac = item;
                                    break;
                                }
                            }
                            if(trazeniGlumac == null)
                            {
                                Console.WriteLine("Glumca nema.");
                                break;
                            }
                            trazeniFilm.DodajGlumca(trazeniGlumac);
                            Console.WriteLine("Glumac je dodan.");
                            break;
                        }
                    case "6":
                        {
                            Console.Write("Unesite ime glumca za pretragu: ");
                            string trazeniGlumac = Console.ReadLine();
                            foreach(Film film in Film.Filmovi)
                            {
                                foreach(Glumac glumac in film.Glumci)
                                {
                                    if(glumac.Prezime.ToLower() == trazeniGlumac.ToLower())
                                    {
                                        Console.WriteLine(film.Ispis());
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                    default:
                            break;
                }
                Console.Write("Vas odabir je: ");
                opcija = Console.ReadLine();
            } while (opcija != "x");
            Console.ReadLine();
        }
    }
}
