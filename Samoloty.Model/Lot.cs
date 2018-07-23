using System;
using System.Collections.Generic;

namespace Samoloty.Model
{
    public  class Lot
    {
        //TODO: Stosuje się konwencję do kolejności pól i metod : 1. Eventy 2. Pola i propertisy 3. Komendy 4. Metody publiczne i prywatne 5. Konstruktory na samym końcu
        // Troche jestem zaskoczony  że konstruktor na samym końcua ale ok poprawione
     
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

        public List<Rezerwacja> Rezerwacje = new List<Rezerwacja>();

        public void Oblicz()
        {
            czasTrwania = Odleglosc / rodzaj.predkosc;
        }
        public void InicjalizujRezerwacje()
        {
            for (int i = 0; i < rodzaj.LiczbaMiejsc; i++)
            {
                Rezerwacje.Add(new Rezerwacja(i));
            }
        }

        public Lot()
        {

        }

    }
}
