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
            listaSamoloty.samoloty.Add(new Samolot() { predkosc = 1000, LiczbaMiejsc = 10, nazwa = "Boeing" });
            listaSamoloty.samoloty.Add(new Samolot() { predkosc = 2000, LiczbaMiejsc = 20, nazwa = "Concorde" });
            ObslugaKonsoli Konsola = new ObslugaKonsoli ();
            String _NazwaSamolotu;
            Int32 _LicznikLotow=0;
            Int32 _Licznik = 0;
            //TODO: Poleciłbym nazwę w stylu _WybranaOpcja zamiast _ZmiennaSwitch
            Int32 _WybranaOpcja; 
            PlanLotu Plan = new PlanLotu();
            while (true)
            {
                _WybranaOpcja= Konsola.ProgramSwitch();
                switch (_WybranaOpcja)
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
                            if (_Licznik == -1)
                            {
                                Konsola.ProgramBladNazywSamolotu();
                                //TODO: Jesteś pewien że chcesz od razu zamknąc aplikację? Nie lepiej wyświetlić błąd i wrócić do głównego menu?
                                //Racja poprawione
                                break;
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
                            //TODO: Tutaj korzysta się z break a nie z continue jesteś pewien że wiesz jak działa switch?
                            // Racja poprawione
                           
                        }
                        //TODO: Podkreślone na zielono fragmentu kodu nigdy się nie wykonają więc możesz je usunąć
                        break;
                    // Dodawanie samoltu
                    case 2:
                        {
                            Samolot NowySamolot = new Samolot();
                            //TODO: nad nazwą listaSamooty bym się zastanowił można wybrac coś bardziej wyrafinowanego :D
                            // Oj tam oj tam
                            listaSamoloty.samoloty.Add(Konsola.ProgramNowySamolot(NowySamolot));
                           
                        }
                        break;
                    // Wyswietlanie lotow
                    case 3:
                        {
                            Lot tmpLot = new Lot();
                            Int32 nrLotu = Konsola.ProgramWyswietlanieLotow(Plan.listaLotow);
                            if (nrLotu == -1)
                            {
                                break;
                            }
                            //TODO: Literówka
                            // Poprawione
                            foreach (Lot element in Plan.listaLotow)
                            {
                                if (element.nrLotu == nrLotu)
                                {
                                    tmpLot = element;
                                    break;
                                }
                            }
                            Konsola.WypiszLot(tmpLot);
                            
                        }
                        break;
                    case 4:
                        {
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        {
                            //TODO: Co oznacza metoda ProgramBladSwitch??? Polska język trudny język :D?
                            //Wolisz program blad przełącznika?
                            Konsola.ProgramBladSwitch();
                        }
                        break;
                }
            }
        } 
    }
}
