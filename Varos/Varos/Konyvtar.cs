using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varos
{
    internal class Konyvtar : Szolgaltatas
    {
        public string Nev { get; set; }
        public List<Konyv> Konyvlista { get; private set; }
        public int Maxkapacitas { get; private set; }

        public List<Lakos> belepok { get; private set; }

        public Konyvtar(string nev, int maxkapacitas) 
        {
            Nev = nev;
            Maxkapacitas = maxkapacitas;
            Konyvlista = new List<Konyv>();
            belepok = new List<Lakos>();
        
        }

        public void Hozzaad(Konyv konyv)
        {

            if (konyv == null || Konyvlista.Contains(konyv) || konyv.Peldanyszam < 0)
            {
                Console.WriteLine("Hiba");
            }
            else
            {
                Console.WriteLine("Könyv hozzáadva könyvtárhoz");
                konyv.Allapot = "Elérhető";
                konyv.Peldanyszam = konyv.Peldanyszam - 1;
                Konyvlista.Add(konyv);
            }

        }


        public void Belepes(Lakos lakos)
        {
            if (belepok.Count >= Maxkapacitas)
            {
                Console.WriteLine("Tele van a könyvtár");
                return;
            } 
             
            if (belepok.Contains(lakos))
            {
                Console.WriteLine("A lakos már a könyvtárban van");
                return;
            }

            belepok.Add(lakos);
            Console.WriteLine($"Sikeresen belépett {lakos.Nev} a könyvtárba");

        }

        public void Kolcsonoz() 
        {
            if (belepok.Count == 0)
            {
                Console.WriteLine("Nicsen senki a könyvtárban!");
                return;
            }

            if (Konyvlista.Count < 0)
            {
                Console.WriteLine("Nincs kölcsönözhető könyv");
                return;
            }
            else
            {
                Console.WriteLine("Elérhető könyvek");
                foreach (Konyv k in Konyvlista)
                {
                    if (k.Peldanyszam > 0)
                    {
                        Console.WriteLine(k.Cim);
                    }
                   
                }
            }
               
            Console.WriteLine("Mit szeretnél ki kölcsönözni?");
            string konyv = Console.ReadLine();
            foreach (Konyv k in Konyvlista)
            {
                if (k.Cim == konyv && k.Allapot == "Elérhető")
                {
                    k.Allapot = "Kikölcsönözve";
                    Console.WriteLine("Sikeresen kikölcsönözted");
                }
            }



        }

        public void Visszahoz(Konyv konyv)
        {
            if (konyv.Allapot == "Kikölcsönzve")
            {
                Console.WriteLine("Sikeresen visszahoztad a könyvet");
                konyv.Allapot = "Elérhető";
                konyv.Peldanyszam += 1;

            }
        }

    }
}
