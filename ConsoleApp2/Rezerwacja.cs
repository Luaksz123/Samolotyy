using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Rezerwacja
    {
        //TODO: Na trello była także wzmianka o code snipets które pomogą Ci szybko tworzyć propertisy a także możesz anpisać sobie swoje włąsne snipety żeby nie pisać wiele razy tego samego
        //TODO: Jeśli chcesz spróbować użyc code snippet możesz napisać w edytorze prop i nacisnąć dwa razy tab zobaczysz co się stanie ;)
        //TODO: Ubogie modele które nic nie robią i zawieraja tylko typy niczego Cię nie nauczą dlatego polecam dodać chociaż jakieś zapisywanie do pliku xml json albo do sqlite zawsze warto się nauczyć
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
        int _Nr;
        public int Nr
        {
            get
            {
                return _Nr;
            }
            set
            {
                _Nr = value;
            }

        }

        public Rezerwacja()
        {
            zajete = false;
        }
        public Rezerwacja(int a)
        {
            Nr = a;
        }
       
    }
   
}
