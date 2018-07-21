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
            ListaSamolotow listaSamoloty = new ListaSamolotow();
            listaSamoloty.samoloty.Add(new Samolot() { predkosc = 1000, liczbaMiejsc = 10, nazwa = "Boeing" });
            listaSamoloty.samoloty.Add(new Samolot() { predkosc = 2000, liczbaMiejsc = 20, nazwa = "Concorde" });

            //TODO: Co oznacza nazwa konsola wczytaj? wczytaj jeden znak jakąs konkretną wartość? opcje?? NazwaZmiennej ma rezprezntować to czym jest, nazywanie zmiennych to bolączka, ale jeśli masz czas i pracujesz nad projektem który nie ma deal lina a ma Ci po prostu pokazać jak się to ma robić dobrze to ma być idealnie ctrl + r ctrl + r pozwala Ci zmienić nazwę zmiennej wraz z jej wszystkimi wystapieniami.
            string konsloaWczytaj;

            //TODO: Straszny syf w tym kodzie cześć operacji wypisywanych do konsoli dzieje się w modelach cześć tutaj w tej klasie. Za co jest ona odpowiedzialana? Albo robisz wszystkie operacje wypisywania w consoli komunikatów i prwoadzenia aplikacji w jednej klasie albo w drugiej. Robi się straszny syf
            int licznik=0;
            //TODO: Raczej stosuj konwencję nazweniczą dla zmiennych lokalnych licznikLotow, dla zmiennym prywatnych _LicznikLotow, a dla zmiennym publicznych LicznikLotow
            int liczniklotow = 0;
            PlanLotu Plan = new PlanLotu();
            System.Console.WriteLine("Dodanie nowego lotu");
            Plan.listaLotow.Add(new Lot());
            System.Console.WriteLine("Wybiez samolot sposrod podanych i wpisze jego nazwe");
            foreach (Samolot element in listaSamoloty.samoloty)
            {
                System.Console.WriteLine(element.nazwa);
            }
            konsloaWczytaj = System.Console.ReadLine();
            foreach (Samolot element in listaSamoloty.samoloty)
            {
               if (element.nazwa == konsloaWczytaj)
                {
                    Plan.listaLotow[liczniklotow].nrLotu = liczniklotow;
                    Plan.listaLotow[liczniklotow].rodzaj = element;
                    licznik++;
                    
                }
            }
            if (licznik == 0)
            {
                System.Console.WriteLine("podano bledna nazwe samolotu");
                Environment.Exit(0);
            }
            
            Plan.listaLotow[liczniklotow].dodajlot();
            Plan.listaLotow[liczniklotow].wypisz();
        }
    }
}
