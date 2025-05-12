using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varos
{
    internal class Posta : Szolgaltatas
    {
        public List<Csomag> Csomagok { get; set; }
        public List<Lakos> Sorbanallok { get; set; }

        public Posta()
        {
            Csomagok = new List<Csomag>();
            Sorbanallok = new List<Lakos>();
        }

        public void Belepes(Lakos lakos)
        {
            if (Sorbanallok.Contains(lakos))
            {
                Console.WriteLine("A Lakos már benne van a Postában");
                return;
            }

            Sorbanallok.Add(lakos);
            Console.WriteLine($"{lakos.Nev} sikeresen belépett a Postába");
        }

        public void Kuldes(Lakos felado, Lakos cimzett, Csomag csomag)
        {
            if (!Sorbanallok.Contains(felado))
            {
                Console.WriteLine("A felado nincs a sorban");
                return;
            }

            if (!felado.Fizet(csomag.Ar))
            {
                Console.WriteLine("A felado nem tudja kifezetni az árát");
                return;
            }

            csomag.Feladas();
            Csomagok.Add(csomag);
            Console.WriteLine("Csomag feladva");
            return;

        }

        public void Sorbanalloklistaja()
        {
            Console.WriteLine("Sorbanállók: ");
            foreach(Lakos lakos in Sorbanallok)
            {
                Console.WriteLine($"{lakos.Nev}");
            }

        }


        public void Szallitas()
        {
            if (Csomagok.Count == 0)
            {
                Console.WriteLine("Nincsen csomag feladva");
                return;
            }

            foreach (Csomag csomag in Csomagok)
            {
                if (csomag.Allapot == "Feladva") ;
                {
                    csomag.Szallitas();
                    Console.WriteLine("Csomag szállítása");
                }
            }
        }


        public void Kiszallitas()
        {
            if (Csomagok.Count == 0)
            {
                Console.WriteLine("Nincsen csomag feladva");
                return;
            }

            foreach(Csomag csomag in Csomagok)
            {
                if (csomag.Allapot == "Szállítás alatt...") 
                {
                    csomag.Kiszallitas();
                    Console.WriteLine("Csomag kiszállítva");
                }
            }


        }

    }
}
