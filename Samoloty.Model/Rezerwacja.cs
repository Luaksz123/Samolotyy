using System;

namespace Samoloty.Model
{
   public class Rezerwacja
    {
        //TODO: Błedna konwencja nazwenicza propertisów i czym jest nr? numerem lotu numerem miejsca czy indywidualnym numerem rezerwacji? Może bardziej dokładna nazwa rozwiąże moje wątpliwości :D?
        String _imie;
        public String imie
        {
            get
            {
                return _imie;
            }
            set
            {
                _imie = value;
            }
        }

        String _nazwisko;
        public String nazwisko
        {
            get
            {
                return _nazwisko;
            }
            set
            {
                _nazwisko = value;
            }

        }
        Boolean _zajete;
        public Boolean zajete
        {
            get
            {
                return _zajete;
            }
            set
            {
                _zajete = value;
            }
        }
        int _NrMiejsca;
        public int NrMiejsca
        {
            get
            {
                return _NrMiejsca;
            }
            set
            {
                _NrMiejsca = value;
            }

        }
        public Rezerwacja()
        {
            zajete = false;
        }
        public Rezerwacja(int a)
        {
            NrMiejsca = a;
        }

    }

}
