using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varos
{
    internal class Bevasarlokozpont : Szolgaltatas
    {
        public List<string> Boltoklistaja {  get; private set; }
        public List<Lakos> Latogatok {  get; private set; }

        public Bevasarlokozpont()
        {
            Boltoklistaja = new List<string>();
            Latogatok = new List<Lakos>();
        }

        public void UjBolt(string bolt)
        {
            if (Boltoklistaja.Contains(bolt))
            {
                Console.WriteLine("Ez a bolt már van a központban");
                return;
            }

            Boltoklistaja.Add(bolt);
            Console.WriteLine("A bolt hozzáadva a központhoz");

        }

        public void Belepes(Lakos lakos)
        {
            if (Latogatok.Contains(lakos))
            {
                Console.WriteLine("A Lakos már benne van a központban");
                return;
            }

            Latogatok.Add(lakos);
            Console.WriteLine($"{lakos.Nev} sikeresen belépett a központba");
        }


        public void Kolt(Lakos lakos, string bolt,int osszeg)
        {
            if (!Boltoklistaja.Contains(bolt))
            {
                Console.WriteLine("Nincs ilyen bolt a központban");
                return;
            }

            if (!Latogatok.Contains(lakos))
            {
                Console.WriteLine($"{lakos.Nev} nincsen a központban");
                return;
            }

            if (!lakos.Fizet(osszeg))
            {
                Console.WriteLine($"{lakos.Nev} nem tudja kifizetni a terméket");
                return;
            }
            else
            {
                Console.WriteLine($"{lakos.Nev} sikeresen bevásárolt");
            }

        }


    }
}
