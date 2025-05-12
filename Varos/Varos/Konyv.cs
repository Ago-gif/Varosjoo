using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varos
{
    internal class Konyv
    {
        public string Cim { get; private set; }
        public string Szerzo { get; private set; }
        
        public int Oldalszam { get; private set; }

        public int Ertek { get; private set; }

        public int Peldanyszam { get; set; }

        public string Allapot { get; set; }

        public Konyv(string cim, string szerzo, int oldalszam, int ertek, int peldanyszam)
        {
            Cim = cim;
            Szerzo = szerzo;
            Oldalszam = oldalszam;
            Ertek = ertek;
            Peldanyszam = peldanyszam;
        }


    }
}
