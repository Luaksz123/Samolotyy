using Samoloty.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samoloty.Console
{
    class ObslugaKonsoli

    {
        

        // TODO Nie jetem pewien czy tak może być, ale nie mam pomysłu jak inaczej przeszukać tutaj listę samolotów stworzoną w głownym programie 
       

        public String ProgramDodajLot(List<Samolot> lista)
        {
            System.Console.WriteLine("Dodanie nowego lotu");
            System.Console.WriteLine("Wybiez samolot sposrod podanych i wpisz jego nazwe");
            foreach (Samolot element in lista)
            {
                System.Console.WriteLine(element.nazwa);
            }
            return System.Console.ReadLine();
        }
        public void ProgramBladNazywSamolotu()
        {
            System.Console.WriteLine("Błędna nazwa samolou");
        }
        public Int32 LotWprowadzNr() {

            System.Console.WriteLine("Podaj nr lotu");
            //TODO: Czy nie będzie Exceptiona po wpisaniu czegoś innego niż int? i aplikacja padnie?
            //Poprawione
            string stringNrLotu = System.Console.ReadLine();
            
            try
            {
                Int32 nr = Int32.Parse(stringNrLotu);
                return  nr;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            return 0;
        }
        public Int32 LotWprowadzOdleglosc()
        {
            System.Console.WriteLine("Podaj odleglosc");
            string stringOdleglosc = System.Console.ReadLine();
            try
            {
                Int32 odleglosc = Int32.Parse(stringOdleglosc);
                return odleglosc;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                return 0;
            }
            
        }
        public Int32 LotRezerwujMiejsce(List<Rezerwacja> rezerwacje) { 
            System.Console.WriteLine("Wolne miejsca");
            foreach (Rezerwacja element in rezerwacje)
            {
                if (element.zajete == false)
                    System.Console.WriteLine(element.Nr);
            }
            System.Console.WriteLine("Podaj miejsce spośród wolnych");
            //TODO: Czy nie będzie Exceptiona po wpisaniu czegoś innego niż int? i aplikacja padnie?
            //Poprawione
            string StringMiejsce = System.Console.ReadLine();
            try
            {
                int nr = Int32.Parse(StringMiejsce);
                if (rezerwacje[nr].zajete ==true)
                {
                    System.Console.WriteLine("Wybrales zajete miejsce");
                    return 0;
                }
                return  nr;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                return 0;
            }
           
        }
        public String LotWczytajImie()
        {

            System.Console.WriteLine("Podaj imie");
            return System.Console.ReadLine();

        }
        public String LotWczytajNazwisko()
        {

            System.Console.WriteLine("Podaj nazwisko");
            return System.Console.ReadLine();
        }

        public void WypiszLot(Lot lot)
        {
            System.Console.WriteLine("Rodzaj samolotu to: {0}", lot.rodzaj.nazwa);
            System.Console.WriteLine("Nr lotu to: {0}", lot.nrLotu);
            System.Console.WriteLine("Odleglosc to: {0}", lot.Odleglosc);
            System.Console.WriteLine("Czas trwania to {0}", lot.czasTrwania);
            System.Console.WriteLine("Wolne miejsca", lot.czasTrwania);
            foreach (Rezerwacja element in lot.Rezerwacje)
            {
                if (element.zajete == false)
                {
                    System.Console.WriteLine("Wolne miejsce nr {0}", element.Nr);
                }
            }
            System.Console.WriteLine("Zajete miejsca");
            foreach (Rezerwacja element in lot.Rezerwacje)
            {
                if (element.zajete == true)
                {
                    System.Console.WriteLine("Miejsce nr {0}", element.Nr);
                    System.Console.WriteLine("Imie {0}", element.imie);
                    System.Console.WriteLine("Nazwisko {0}", element.nazwisko);
                }
            }
        }
        public Int32 ProgramSwitch()
        {
            System.Console.WriteLine("Wprowadz\n 1 Aby dodac nowy lot\n 2 Abydodac samolot\n 3 Aby wswietlic lot \n 4 Aby wyjsc z programu");
            string stringSwitch = System.Console.ReadLine();
            try
            {
                int nr = Int32.Parse(stringSwitch);
                return nr;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                return 0;
            }
        }
        // TODO moge tutaj wczytać wszystkie rzeczy niezbędne do stworzenia samolotu i zwrócić gotowy obiekt do programu głownego
        // czy wczytywać osobnymi metodami nazewe, preskows i liczbe miejsc?
        public Samolot ProgramNowySamolot(Samolot NowySamolot)
        {
            System.Console.WriteLine("Wprowadz nazwe samolotu");
            NowySamolot.nazwa = System.Console.ReadLine();
            System.Console.WriteLine("Wprowadz liczbe miejsc");
            string stringLiczbaMIejsc = System.Console.ReadLine();
            try
            {
                int liczbaMiejsc = Int32.Parse(stringLiczbaMIejsc);
                
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            //TODO Nie wiem czy to ponizej jest poprawne. Jak wyciagnac potem inta z try i przypisac do czegos, w sencie wyciagnac liczbaMiejsc i przypisac do NowySamolot.liczbaMiejsc ? 
            // Wydaje mi sie ze jezeli wczesniej try nie wykrył błędu to chyba tak można.
            NowySamolot.liczbaMiejsc= Int32.Parse(stringLiczbaMIejsc);
            System.Console.WriteLine("Wprowadz predkosc");
            string stringPredkosc = System.Console.ReadLine();
            try
            {
                int liczbaMiejsc = Int32.Parse(stringPredkosc);

            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            NowySamolot.predkosc= Int32.Parse(stringPredkosc);
            return NowySamolot;
        }
        public Int32 ProgramWyswietlanieLotow(List<Lot> listaLotow )
        {
            Int32 licznik=0;
            System.Console.WriteLine("Lista dostepnych lotow");
            foreach (Lot element in listaLotow)
            {
                System.Console.WriteLine("{0}", element.nrLotu);
                licznik++;
            }
            if (licznik == 0)
            {
                System.Console.WriteLine("Brak dostepnych lotów");
                return 0;
            }
            System.Console.WriteLine("Wprowadz nr lotu ktory chcesz wyswietlic");
            string stringNrLotu = System.Console.ReadLine();
            try
            {
                int tmpNrLotu = Int32.Parse(stringNrLotu);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            int nrLotu = Int32.Parse(stringNrLotu);
            licznik = 0;
            foreach (Lot element in listaLotow)
            {
                if (element.nrLotu==nrLotu)
                {
                    licznik++;
                }
            }
            if (licznik == 0)
            {
                System.Console.WriteLine("Podano niepoprawny numer lotu");
                return 0;
            }
            return nrLotu;
        }
        public void ProgramBladSwitch()
        {
            System.Console.WriteLine("Podano błedna wartosc");
        }
    }
}
