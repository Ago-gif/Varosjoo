using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Varos
{
    internal class Eteltal
    {
        public string Nev { get; private set; }
        public int Ar {  get; private set; }
        public string Tipus {  get; private set; }
        public int Koffein { get; private set; }

        public int Kaloria { get; private set; }


        public Eteltal(string nev, int ar, string tipus, int koffein, int kaloria)
        {
            Nev = nev;
            Ar = ar;
            Tipus = tipus;
            Koffein = koffein;
            Kaloria = kaloria;
                
        }



    }
}
