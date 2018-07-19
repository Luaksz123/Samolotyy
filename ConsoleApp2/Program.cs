using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Samoloty
{
    //TODO: Za te nazwy aplikacji to Ci ktoś w zespole krzywde zrobi albo Cie zbluzga. Dlatego polecam nazywać odpowiednio nazwy projektów np. Samoloty.Model Samoloty.Desktop Samoloty.IOS a całą solucję jako samoloty wtedy automatycznie tworzą Ci sie odpowiednie przestrzenie nazw które w większych projektach sa przydatne bo potem brakuje nazw dla klas a przez przestrzenie wszystko jest uporządkowane :)
    class Program
    {
        static void Main(string[] args)
        {
            ListaSamolotow listaSamoloty = new ListaSamolotow();
            listaSamoloty.samoloty.Add(new Samolot() { predkosc = 1000, liczbaMiejsc = 10, nazwa = "Boeing" });
            listaSamoloty.samoloty.Add(new Samolot() { predkosc = 2000, liczbaMiejsc = 20, nazwa = "Concorde" });

            //TODO: Nie zrobiłeś porządku za sobą i nadal widze nazwy zmiennych tmp tmp1 co one mają oznaczać? Chciałbyś zaglądać do czyjegoś kodu gdzie każda zmienna nazywa się przez a , b, c oczywiście zdarza się że ktoś tak nazwie, bo się spieszy, ale code review jest po to żeby zauważyć ten błąd i żeby auto mógł go poprawić na przyszłość.
            // poprawione
            string konsloaWczytaj;

            int licznik=0;
            int liczniklotow = 0;
            PlanLotu Plan = new PlanLotu();
            Console.WriteLine("Dodanie nowego lotu");
            Plan.listaLotow.Add(new Lot());
            Console.WriteLine("Wybiez samolot sposrod podanych i wpisze jego nazwe");
            foreach (Samolot element in listaSamoloty.samoloty)
            {
                Console.WriteLine(element.nazwa);
            }
            konsloaWczytaj = Console.ReadLine();
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
                Console.WriteLine("podano bledna nazwe samolotu");
                Environment.Exit(0);
            }
            // Do dorobienia przechwycenie bledu zapobiegajacego wpisaniu liczby
            //TODO: Czemu służa takie komentarze w kodzie?
            //Poprawione
            Plan.listaLotow[liczniklotow].dodajlot();
            Plan.listaLotow[liczniklotow].wypisz();
        }
        // To poniezje moze mi się jeszcze przydac proszę się nie czepiać
        /*catch (Exception e) 
        {
            //TODO: Jeśli łapiwesz tylko FormatException to żaden inny exception nie będzie przechwycony dlatego moim zdaniem najbezpieczniej chwytać zwykły Exception jeśli nie planujesz ich rozbijać albo robić specjalnych operacji w zależności od wyjątku.
            Console.WriteLine(e.Message);
        }*/
       
        
    }
}
