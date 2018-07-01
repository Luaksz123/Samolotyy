using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Lot
    {
        Samolot Rodzaj;
        public  int nrLotu;
        public double Odleglosc;
        public double czasTrwania;
        public Rezerwacja [] tab;
        public Boolean zajety;

        public void oblicz()
        {
            czasTrwania = Odleglosc / Rodzaj.getPredkosc();
        }
        public Lot (Samolot a)
        {
            Rodzaj = a;
            this.tab = new Rezerwacja[Rodzaj.getliczbaMiejsc()];
            for (int i = 0; i < Rodzaj.getliczbaMiejsc(); i++)
                tab[i] = new Rezerwacja(i);
        }
        public Lot()
        {
            zajety = false;
        }
        public void dodajlot()
        {
            Console.WriteLine("Podaj nr lotu");
            nrLotu = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj odleglosc");
            Odleglosc = int.Parse(Console.ReadLine());
            this.oblicz();
            Console.WriteLine("Wolne miejsca");
            for (int i=0;i< Rodzaj.getliczbaMiejsc();i++)
            {
                if (tab[i].getzajete()==false)
                    Console.WriteLine(tab[i].getnr());
            }
            Console.WriteLine("Podaj miejsce spośród wolnych");
            int tmp= int.Parse(Console.ReadLine());
            tab[tmp].setzajete(true);
            Console.WriteLine("Podaj imie");
            tab[tmp].setimie(Console.ReadLine());
            Console.WriteLine("Podaj nazwisko");
            tab[tmp].setnazwisko(Console.ReadLine());
        }
        public void wypisz()
        {
            Console.WriteLine("Rodzaj samolotu to: {0}",Rodzaj.getNazwa());
            Console.WriteLine("Nr lotu to: {0}", nrLotu);
            Console.WriteLine("Odleglosc to: {0}", Odleglosc);
            Console.WriteLine("Czas trwania to {0}", czasTrwania);
            Console.WriteLine("Wolne miejsca", czasTrwania);
            for (int i = 0; i < Rodzaj.getliczbaMiejsc(); i++)
            {
                if (tab[i].getzajete() == false)
                {
                    Console.WriteLine("Wolne miejsce nr {0}", tab[i].getnr());
                }
            }
            Console.WriteLine("Zajete miejsca", czasTrwania);
            for (int i = 0; i < Rodzaj.getliczbaMiejsc(); i++)
            {
                if (tab[i].getzajete() == true)
                {
                    Console.WriteLine("Miejsce nr {0}", tab[i].getnr());
                    Console.WriteLine("Imie {0}", tab[i].getimie());
                    Console.WriteLine("Nazwisko {0}", tab[i].getnazwisko());
                }
            }
        }
    }
}
