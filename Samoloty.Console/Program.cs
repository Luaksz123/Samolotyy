using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Samoloty.Model;


namespace Samoloty.Console
{
    //TODO: Za te nazwy aplikacji to Ci ktoś w zespole krzywde zrobi albo Cie zbluzga. Dlatego polecam nazywać odpowiednio nazwy projektów np. Samoloty.Model Samoloty.Desktop Samoloty.IOS a całą solucję jako samoloty wtedy automatycznie tworzą Ci sie odpowiednie przestrzenie nazw które w większych projektach sa przydatne bo potem brakuje nazw dla klas a przez przestrzenie wszystko jest uporządkowane :)
    // Zrobione
    class Program
    {
        static void Main(string[] args)
        {
            ListaSamolotow listaSamoloty;
            listaSamoloty= new ListaSamolotow();
            listaSamoloty.samoloty.Add(new Samolot() { predkosc = 1000, liczbaMiejsc = 10, nazwa = "Boeing" });
            listaSamoloty.samoloty.Add(new Samolot() { predkosc = 2000, liczbaMiejsc = 20, nazwa = "Concorde" });
            ObslugaKonsoli Konsola = new ObslugaKonsoli ();
            //TODO: Co oznacza nazwa konsola wczytaj? wczytaj jeden znak jakąs konkretną wartość? opcje?? NazwaZmiennej ma rezprezntować to czym jest, nazywanie zmiennych to bolączka, ale jeśli masz czas i pracujesz nad projektem który nie ma deal lina a ma Ci po prostu pokazać jak się to ma robić dobrze to ma być idealnie ctrl + r ctrl + r pozwala Ci zmienić nazwę zmiennej wraz z jej wszystkimi wystapieniami.
            // Zrobione
            String _NazwaSamolotu;
            //TODO: Straszny syf w tym kodzie cześć operacji wypisywanych do konsoli dzieje się w modelach cześć tutaj w tej klasie. Za co jest ona odpowiedzialana? Albo robisz wszystkie operacje wypisywania w consoli komunikatów i prwoadzenia aplikacji w jednej klasie albo w drugiej. Robi się straszny syf
            Int32 _LicznikLotow=0;
            Int32 _Licznik = 0;
            Int32 _ZmiennaSwitch; 
            //TODO: Raczej stosuj konwencję nazweniczą dla zmiennych lokalnych _LicznikLotow, dla zmiennym prywatnych __LicznikLotow, a dla zmiennym publicznych _LicznikLotow
            // Dodawanie nowego lotu
            PlanLotu Plan = new PlanLotu();
            while (true)
            {
                _ZmiennaSwitch= Konsola.ProgramSwitch();
                switch (_ZmiennaSwitch)
                {
                    case 1:
                        {
                            Plan.listaLotow.Add(new Lot());
                            _NazwaSamolotu = Konsola.ProgramDodajLot(listaSamoloty.samoloty);
                            foreach (Samolot element in listaSamoloty.samoloty)
                            {
                                if (element.nazwa == _NazwaSamolotu)
                                {
                                    Plan.listaLotow[_LicznikLotow].nrLotu = Konsola.LotWprowadzNr();
                                    Plan.listaLotow[_LicznikLotow].rodzaj = element;
                                    _Licznik++;
                                }
                            }
                            if (_Licznik == 0)
                            {
                                Konsola.ProgramBladNazywSamolotu();
                                Environment.Exit(0);
                            }
                            Plan.listaLotow[_LicznikLotow].InicjalizujRezerwacje();
                            Plan.listaLotow[_LicznikLotow].Odleglosc = Konsola.LotWprowadzOdleglosc();
                            Plan.listaLotow[_LicznikLotow].Oblicz();
                            Int32 NrRezerwacji = Konsola.LotRezerwujMiejsce(Plan.listaLotow[_LicznikLotow].Rezerwacje);
                            Plan.listaLotow[_LicznikLotow].Rezerwacje[NrRezerwacji].zajete = true;
                            String Imie = Konsola.LotWczytajImie();
                            Plan.listaLotow[_LicznikLotow].Rezerwacje[NrRezerwacji].imie = Imie;
                            String Nazwisko = Konsola.LotWczytajNazwisko();
                            Plan.listaLotow[_LicznikLotow].Rezerwacje[NrRezerwacji].nazwisko = Nazwisko;
                            _LicznikLotow++;
                            continue;
                        }
                        break;
                    // Dodawanie samoltu
                    case 2:
                        {
                            Samolot NowySamolot = new Samolot();
                            listaSamoloty.samoloty.Add(Konsola.ProgramNowySamolot(NowySamolot));
                            continue;
                        }
                        break;
                    // Wyswietlanie lotow
                    case 3:
                        {
                            Lot tmpLot = new Lot();
                            Int32 nrLotu = Konsola.ProgramWyswietlanieLotow(Plan.listaLotow);
                            if (nrLotu == 0)
                            {
                                break;
                            }
                            foreach (Lot elemnt in Plan.listaLotow)
                            {
                                if (elemnt.nrLotu == nrLotu)
                                {
                                    tmpLot = elemnt;
                                    break;
                                }
                            }
                            Konsola.WypiszLot(tmpLot);
                            continue;
                        }
                        break;
                    case 4:
                        {
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        {
                            Konsola.ProgramBladSwitch();
                        }
                        break;
                }
            }
        }
            
        
        
    }
}
