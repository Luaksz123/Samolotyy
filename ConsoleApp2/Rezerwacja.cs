using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Rezerwacja
    {
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
