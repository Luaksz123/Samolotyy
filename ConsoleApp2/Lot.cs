using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samoloty
{
    class Lot
    {
        //TODO: Skoro klasa ma tyle pól publicznych to może jakaś enkapsulacja i konstruktor do inicjalizacji?
        // Zmiana na privat i dodanie propertisów
        // Zmiana załozen. Wywalilem klasy concorde i boeing

        private Samolot _rodzaj;

        public Samolot rodzaj
        {
            get { return _rodzaj; }
            set { _rodzaj = value; }
        }

        private int _nrLotu;

        public int nrLotu
        {
            get { return _nrLotu; }
            set { _nrLotu = value; }
        }

        private double _Odlelosc;

        public double Odleglosc
        {
            get { return _Odlelosc; }
            set { _Odlelosc = value; }
        }

        private double _czasTrwania;

        public double czasTrwania
        {
            get { return _czasTrwania;}
            set { _czasTrwania = value; }
        }

        //TODO: Nie wiem dlaczego tutaj nadal jest tablica? Możesz sobie je stosowac ale wydaje mi się że w bardziej praktycznych zastosowaniach będziesz później i tak chciał korzystać z struktur dynamicznych.
        // Jeżeli ta tablica reprezentuje liczbe miejsc która jest stała dla danego lotu też robic lite?
        //TODO: XCzy nie można jakoś normalnie nazwać tej tablicy?
        public Rezerwacja [] tab;

        public Lot()
        {

        }

        public void oblicz()
        {
            czasTrwania = Odleglosc / rodzaj.predkosc;
        }
        private void dodajRezerwacje()
        {
            //TODO: Nazywaj dobrze nazwy zmiennych ten kod ma być wizytówką ;)
            //a zmienione na samolot nie wiem czy mozna nazywac zmienna ta sama nazwa co typ
            this.tab = new Rezerwacja[rodzaj.liczbaMiejsc];
            for (int i = 0; i < rodzaj.liczbaMiejsc; i++)
            {
                tab[i] = new Rezerwacja(i);
            }
        }
        
        public void dodajlot()
        {
            int nrMiejsca=0;
            dodajRezerwacje();
            Console.WriteLine("Podaj nr lotu");
            //TODO: Czy nie będzie Exceptiona po wpisaniu czegoś innego niż int? i aplikacja padnie?
            string stringNrLotu = Console.ReadLine();
            try
            {
                int nr =Int32.Parse(stringNrLotu);
                nrLotu = nr;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Podaj odleglosc");
            Odleglosc = int.Parse(Console.ReadLine());
            this.oblicz();
            Console.WriteLine("Wolne miejsca");
            for (int i=0;i< rodzaj.liczbaMiejsc;i++)
            {
                if (tab[i].zajete==false)
                Console.WriteLine(tab[i].Nr);
            }
            Console.WriteLine("Podaj miejsce spośród wolnych");
            //TODO: Czy nie będzie Exceptiona po wpisaniu czegoś innego niż int? i aplikacja padnie?
            string StringMiejsce= Console.ReadLine();
            try
            {
                int nr = Int32.Parse(StringMiejsce);
                nrMiejsca= nr;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            tab[nrMiejsca].zajete=true;
            Console.WriteLine("Podaj imie");
            tab[nrMiejsca].imie=Console.ReadLine();
            Console.WriteLine("Podaj nazwisko");
            tab[nrMiejsca].nazwisko=Console.ReadLine();
        }
        public void wypisz()
        {
            Console.WriteLine("Rodzaj samolotu to: {0}",rodzaj.nazwa);
            Console.WriteLine("Nr lotu to: {0}", nrLotu);
            Console.WriteLine("Odleglosc to: {0}", Odleglosc);
            Console.WriteLine("Czas trwania to {0}", czasTrwania);
            Console.WriteLine("Wolne miejsca", czasTrwania);
            for (int i = 0; i < rodzaj.liczbaMiejsc; i++)
            {
                if (tab[i].zajete== false)
                {
                    Console.WriteLine("Wolne miejsce nr {0}", tab[i].Nr);
                }
            }
            Console.WriteLine("Zajete miejsca", czasTrwania);
            for (int i = 0; i < rodzaj.liczbaMiejsc; i++)
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
