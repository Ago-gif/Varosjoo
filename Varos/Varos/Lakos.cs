using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varos
{
    internal class Lakos
    {

         public string Nev { get; private set; }
         public int Eletkor { get; private set; }
         
         public string Lakcim { get; private set; }
         
         public int Penzosszeg { get; private set; }
    
    
        public Lakos(string nev, int eletkor, string lakcim, int penzosszeg)
        {
            Nev = nev;
            Eletkor = eletkor;
            Lakcim = lakcim;
            Penzosszeg = penzosszeg;
        }



        public bool Fizet(int osszeg)
        {
            if (osszeg <= 0)
            {
                Console.WriteLine($"Az összeg nem lehet negatív");
                return false;
            }

            if (Penzosszeg >= osszeg)
            {
                Penzosszeg -= osszeg;
                Console.WriteLine($"{Nev}: Sikeresen kifezetted, {Penzosszeg} Ftod maradt");
                return true;
            }
            else
            {
                Console.WriteLine($"{Nev}: Nincs elég pénzed erre");
                return false;
            }
        }


        public void Hasznalkozlekedest(Kozlekedes kozlekedes)
        {
            kozlekedes.Felszalas(this);
        }


    }


}
