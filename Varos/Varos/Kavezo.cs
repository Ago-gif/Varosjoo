using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varos
{
    internal class Kavezo : Szolgaltatas
    {
        public List<Eteltal> Menu { get; private set; }
        public List<Lakos> Vendeglista { get; private set; }

        public List<Eteltal> Rendelesek { get; private set; }

        public Kavezo()
        {
            Menu = new List<Eteltal>();
            Vendeglista = new List<Lakos>();
            Rendelesek = new List<Eteltal>();
        }

        public void Belepes(Lakos lakos)
        {
            if (Vendeglista.Contains(lakos))
            {
                Console.WriteLine("A lakos már bennt van a Kávézóban");
                return;
            }

            Vendeglista.Add(lakos);
            Console.WriteLine($"Sikeresen belépett {lakos.Nev} a Kávézóba");
        }

        public void HozzaadMenu(Eteltal Etel)
        {
            if (Menu.Contains(Etel))
            {
                Console.WriteLine("Étel már benne van a Menüben");
            }
            else
            {
                Menu.Add(Etel);
                Console.WriteLine("Étel hozzáadva a menühöz");
            }
             
        }

        public void Rendeles(Lakos lakos, Eteltal etel)
        {
            if (!Menu.Contains(etel))
            {
                Console.WriteLine("Nincs az étel a menüben");
                return;
            }

            Rendelesek.Add(etel);
            Console.WriteLine($"{etel.Nev} termék meg lett rendelve");


        }

        public void Fizet(Lakos lakos)
        {
            int osszeg = 0;
            foreach(Eteltal etel in Rendelesek)
            {
                osszeg += etel.Ar;
            }
            Console.WriteLine($"{osszeg} Ft a rendelés összesen");

            if (lakos.Fizet(osszeg) == false)
            {
                Console.WriteLine($"{lakos.Nev} nem tudja kifizetni");
                return;
            } else
            {
                Console.WriteLine("Sikeresen kifizetve");
            }

        }
        public void Fogyaszt(Lakos lakos)
        {
            Console.WriteLine($"{lakos.Nev} elfogyasztotta az ételét");
        }



    }
}
