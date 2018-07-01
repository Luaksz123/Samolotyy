using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Rezerwacja
    {
        String imie;
        String nazwisko;
        Boolean zajete;
        int Nr;

        public Rezerwacja()
        {
            zajete = false;
        }
        public Rezerwacja(int a)
        {
            Nr=a;
        }
        public string getimie()
        {
            return imie;
        }
        public string getnazwisko()
        {
            return nazwisko;
        }
        public Boolean getzajete()
        {
            return zajete;
        }
        public int getnr()
        {
            return Nr;
        }

        public void setimie(string a)
        {
             imie=a;
        }
        public void setnazwisko(string a)
        {
            nazwisko=a;
        }
        public void setzajete(Boolean a)
        {
             zajete=a;
        }
        public void setnr(int a)
        {
            Nr=a;
        }
       

    }

   
}
