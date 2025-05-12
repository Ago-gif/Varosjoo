using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varos
{
    internal class Kozlekedes
    {
        public string Nev { get; set; }
        public List<string> Utvonal { get; set; }
        
        public int Ferohely { get; set; }

        public int Jegyar { get; set; }

        public List<Lakos> utasok { get; set; }
        
        public int megallo { get; set; }

        public Kozlekedes(string nev, int ferohely, int jegyar, List<string> utvonal)
        {
            Nev = nev;
            Utvonal = utvonal;
            Ferohely = ferohely;
            Jegyar = jegyar;
            utasok = new List<Lakos>();
            megallo = 0;

        }
           

        public void Felszalas(Lakos lakos)
        {
            if (Ferohely <= utasok.Count)
            {
                Console.WriteLine("Tele van a busz!");
                return;
            }

            if (utasok.Contains(lakos))
            {
                Console.WriteLine("Az utas már a járműn van!");
                return;
            }

            utasok.Add(lakos);
            Console.WriteLine($" {lakos.Nev} sikeresen felszállt a {Nev} nevű járműre");
        }

        public void Lepes()
        {
            if (megallo > Utvonal.Count)
            {
                megallo += 1;
            } else
            {
                megallo = 0;
                Console.WriteLine($"A busz újra kezdi a járatot a {Utvonal[0]} megállón");
                return;
            }

                Console.WriteLine($"A {Nev} sikeresen elérte a(z) {Utvonal[megallo]} megallót");
        }

        public void Leszallas(Lakos lakos)
        {
            if (utasok.Contains(lakos))
            {
                utasok.Remove(lakos);
                Console.WriteLine($"{lakos.Nev} leszállt a járműről");
            }
        }

    }
}
