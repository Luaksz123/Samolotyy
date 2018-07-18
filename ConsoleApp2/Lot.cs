using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Lot
    {
        //TODO: Skoro klasa ma tyle pól publicznych to może jakaś enkapsulacja i konstruktor do inicjalizacji?
        Samolot Rodzaj;
        public  int nrLotu;
        public double Odleglosc;
        public double czasTrwania;
        //TODO: Nie wiem dlaczego tutaj nadal jest tablica? Możesz sobie je stosowac ale wydaje mi się że w bardziej praktycznych zastosowaniach będziesz później i tak chciał korzystać z struktur dynamicznych.
        public Rezerwacja [] tab;
        //TODO: Jesli coś przestaje być potrzebne to to usuwamy żeby nie była zaśmiecania kodu. Zawsze w historii pliku na gicie można poszukac tego i skopiować jeśli będzie potrzbne :)
        //public Boolean zajety;

        public void oblicz()
        {
            czasTrwania = Odleglosc / Rodzaj.getPredkosc();
        }
        public void dodajLot (Samolot a)
        {
            //TODO: Nazywaj dobrze nazwy zmiennych ten kod ma być wizytówką ;)
            Rodzaj = a;
            this.tab = new Rezerwacja[Rodzaj.getliczbaMiejsc()];
            //TODO: Nie polecam stosowania forów bez {} ani ifów bo potem błędy dzieją się i nie wiadomo skąd szukanie takie błędu zajmuje potem kilka godzin a te {} nic nie kosztują
            for (int i = 0; i < Rodzaj.getliczbaMiejsc(); i++)
                tab[i] = new Rezerwacja(i);
        }
        public Lot()
        {
           
        }
        public void dodajlot()
        {
            Console.WriteLine("Podaj nr lotu");
            //TODO: Czy nie będzie Exceptiona po wpisaniu czegoś innego niż int? i aplikacja padnie?
            nrLotu = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj odleglosc");
            Odleglosc = int.Parse(Console.ReadLine());
            this.oblicz();
            Console.WriteLine("Wolne miejsca");
            for (int i=0;i< Rodzaj.getliczbaMiejsc();i++)
            {
                if (tab[i].zajete==false)
                Console.WriteLine(tab[i].Nr);
            }
            Console.WriteLine("Podaj miejsce spośród wolnych");
            //TODO: Czy nie będzie Exceptiona po wpisaniu czegoś innego niż int? i aplikacja padnie?
            int tmp= int.Parse(Console.ReadLine());
            tab[tmp].zajete=true;
            Console.WriteLine("Podaj imie");
            tab[tmp].imie=Console.ReadLine();
            Console.WriteLine("Podaj nazwisko");
            tab[tmp].nazwisko=Console.ReadLine();
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
                if (tab[i].zajete== false)
                {
                    Console.WriteLine("Wolne miejsce nr {0}", tab[i].Nr);
                }
            }
            Console.WriteLine("Zajete miejsca", czasTrwania);
            for (int i = 0; i < Rodzaj.getliczbaMiejsc(); i++)
            {
                if (tab[i].zajete == true)
                {
                    Console.WriteLine("Miejsce nr {0}", tab[i].Nr);
                    Console.WriteLine("Imie {0}", tab[i].imie);
                    Console.WriteLine("Nazwisko {0}", tab[i].nazwisko);
                }
            }
        }
    }
}
