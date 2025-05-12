using System.Net.Http.Headers;

namespace Varos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Varos varos = new Varos("Nyíregyháza");


            Lakos Anna = (new Lakos("Anna", 30, "Fő utca 1", 10000));
            varos.HozzaadLakos(Anna);

            Lakos Bela = new Lakos("Béla", 25, "Diófa utca 2", 8000);
            varos.HozzaadLakos(Bela);

            Lakos Cili = new Lakos("Cili", 35, "Akácfa u. 3", 12000);
            varos.HozzaadLakos(Cili);

            Lakos Dani = new Lakos("Dani", 28, "Petőfi tér 5", 9500);
            varos.HozzaadLakos(Dani);

       
            Lakos Erika = new Lakos("Erika", 22, "Tavasz u. 6", 7000);
            varos.HozzaadLakos(Erika);

            Lakos Ferenc = new Lakos("Ferenc", 40, "Hársfa u. 7", 15000);
            varos.HozzaadLakos(Ferenc);

            Lakos Gabi = new Lakos("Gabi", 27, "Jókai u. 8", 11000);
            varos.HozzaadLakos(Gabi);

            Lakos Hedi = new Lakos("Hédi", 33, "Kossuth u. 9", 10500);
            varos.HozzaadLakos(Hedi);

            Lakos Imre = new Lakos("Imre", 45, "Széchenyi u. 10", 13000);
            varos.HozzaadLakos(Imre);

            Lakos Juli = new Lakos("Juli", 20, "Vasút sor 11", 6000);
            varos.HozzaadLakos(Juli);

            Konyvtar konyvtar = new Konyvtar("Könyvtár", 10);
            konyvtar.Hozzaad(new Konyv("Az Ember Tragédiája", "Madách Imre", 150, 2000, 3));
            konyvtar.Hozzaad(new Konyv("Egri csillagok", "Gárdonyi Géza", 350, 2500, 2));
            konyvtar.Hozzaad(new Konyv("Pál utcai fiúk", "Molnár Ferenc", 180, 1800, 4));
            konyvtar.Hozzaad(new Konyv("Tüskevár", "Fekete István", 250, 2200, 3));
            konyvtar.Hozzaad(new Konyv("A kőszívű ember fiai", "Jókai Mór", 400, 2800, 1));

            konyvtar.Belepes(Anna);
            konyvtar.Belepes(Bela);
            konyvtar.Belepes(Imre);
            konyvtar.Kolcsonoz();


            List<string> utvonal = ["Fő tér", "Nagy tér", "Közép tér"];
            Kozlekedes busz = new Kozlekedes("12", 20, 200, utvonal);
            busz.Felszalas(Anna);
            busz.Felszalas(Juli);
            busz.Felszalas(Imre);
            busz.Felszalas(Hedi);
            busz.Felszalas(Gabi);


            Eteltal suti = new Eteltal("Süti", 550, "Édesség", 0, 200);
            Eteltal kave = new Eteltal("Kávé", 700, "Ital", 100, 100);
            Kavezo cicakavezo = new Kavezo();
            cicakavezo.Belepes(Juli);
            cicakavezo.HozzaadMenu(kave);
            cicakavezo.HozzaadMenu(suti);
            cicakavezo.Rendeles(Juli, kave);
            cicakavezo.Rendeles(Juli, suti);
            cicakavezo.Fogyaszt(Juli);
            cicakavezo.Fizet(Juli);

            Csomag ajandek = new Csomag(Imre, Juli, 1000, 1000);
            Posta posta = new Posta();

            posta.Belepes(Imre);
            posta.Kuldes(Imre, Juli, ajandek);
            posta.Sorbanalloklistaja();
            





        }


    }
}
