using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varos
{
    internal class Csomag
    {
        public Lakos Kuldo { get; set; }
        public Lakos Cimzett { get; set; }

        public int Suly { get; private set; }
        public int Ar { get; private set; }
        public string Allapot { get; set; }


        public Csomag(Lakos kuldo, Lakos cimzett, int suly, int ar)
        {
            Kuldo = kuldo;
            Cimzett = cimzett;
            Suly = suly;
            Ar = ar;
            Allapot = "Semmi";

        }

        public void Feladas()
        {
            Allapot = "Feladva";
            Console.WriteLine("A csomag feladva");
        }

        public void Szallitas()
        {
            if (Allapot == "Feladva")
            {
                Allapot = "Szallítás...";
            }
        }

        public void Kiszallitas()
        {
            if (Allapot == "Szallítás...")
            {
                Allapot = "Kiszállítva";
            }
        }




    }
}
