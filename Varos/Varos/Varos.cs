using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varos
{
    internal class Varos
    {
        public List<Lakos> Lakosok { get; set; }
        public string Varosnev { get; set; }

        public Varos(string varosnev)
        {
            Varosnev = varosnev;
            Lakosok = new List<Lakos>();
        }

        public void HozzaadLakos(Lakos lakos)
        {
            if (Lakosok.Contains(lakos))
            {
                Console.WriteLine("A lakos már a városban van");
                return;
            }

            Lakosok.Add(lakos);
        }

        public void Varosstatusz()
        {
            Console.WriteLine($"A város neve: {Varosnev}");
            Console.WriteLine($"Lakosok: {Lakosok.Count}");
        }

    }
}
