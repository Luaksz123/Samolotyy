using System;
using System.Collections.Generic;

namespace Samoloty.Model
{
    public  class Lot
    {
        //TODO: Skoro klasa ma tyle pól publicznych to może jakaś enkapsulacja i konstruktor do inicjalizacji?
        // Zmiana na privat i dodanie propertisów
        // Zmiana załozen. Wywalilem klasy concorde i boeing

        public Lot()
        {
           
        }
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


        //TODO: Nie wiem dlaczego tutaj nadal jest tabRezerwacjelica? Możesz sobie je stosowac ale wydaje mi się że w bardziej praktycznych zastosowaniach będziesz później i tak chciał korzystać z struktur dynamicznych.
        // Jeżeli ta tabRezerwacjelica reprezentuje liczbe miejsc która jest stała dla danego lotu też robic lite?
        //TODO: XCzy nie można jakoś normalnie nazwać tej tabRezerwacjelicy?
        // Zmieniłem ale nie wiem czy Ci się spodoba 
        public List<Rezerwacja> Rezerwacje = new List<Rezerwacja>() ;

       

        public void Oblicz()
        {
            czasTrwania = Odleglosc / rodzaj.predkosc;
        }
        public void InicjalizujRezerwacje()
        {
            //TODO: Nazywaj dobrze nazwy zmiennych ten kod ma być wizytówką ;)
            // a zmienione na samolot nie wiem czy mozna nazywac zmienna ta sama nazwa co typ
            
            for (int i = 0; i < rodzaj.liczbaMiejsc; i++)
            {
                Rezerwacje.Add(new Rezerwacja(i));
            }

        }
       
    }
}
