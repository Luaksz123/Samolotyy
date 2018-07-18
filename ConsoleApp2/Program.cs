using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    //TODO: Za te nazwy aplikacji to Ci ktoś w zespole krzywde zrobi albo Cie zbluzga. Dlatego polecam nazywać odpowiednio nazwy projektów np. Samoloty.Model Samoloty.Desktop Samoloty.IOS a całą solucję jako samoloty wtedy automatycznie tworzą Ci sie odpowiednie przestrzenie nazw które w większych projektach sa przydatne bo potem brakuje nazw dla klas a przez przestrzenie wszystko jest uporządkowane :)
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Nie zrobiłeś porządku za sobą i nadal widze nazwy zmiennych tmp tmp1 co one mają oznaczać? Chciałbyś zaglądać do czyjegoś kodu gdzie każda zmienna nazywa się przez a , b, c oczywiście zdarza się że ktoś tak nazwie, bo się spieszy, ale code review jest po to żeby zauważyć ten błąd i żeby auto mógł go poprawić na przyszłość.
            int tmp;
            string tmp1;

            int LicznikLotow = 0; //Wiem że powinien być globalny dorobie potem
            PlanLotu Plan = new PlanLotu();
            Console.WriteLine("Dodanie nowego lotu");
            Plan.dodaj();
            Console.WriteLine("Wybiez samolot \n 1 Boeing \n 2 Concorde");
            int count = Plan.listaLotow.Count-1;
            tmp1 =Console.ReadLine();
            try
            {
                tmp = Int32.Parse(tmp1); // Nie wim czy lepiej wszystku wrzucić w try czy zrobić tmp zmienną globalną
                if (tmp == 1)
                {
                  //TODO: Nie wiem jak Ciebie ale mnie count informuje o sumie a tutaj chyba to zmienna która przechowuje indeks wybrane samolotu nie?
                    Plan.listaLotow[count].dodajLot(new Boeing());
                }
                if (tmp == 2)
                {
                    Plan.listaLotow[count].dodajLot(new Concorde());
                }
                //TODO: Czemu służa takie komentarze w kodzie?
                //dsada
            }
            catch (FormatException e)
            {
                //TODO: Jeśli łapiwesz tylko FormatException to żaden inny exception nie będzie przechwycony dlatego moim zdaniem najbezpieczniej chwytać zwykły Exception jeśli nie planujesz ich rozbijać albo robić specjalnych operacji w zależności od wyjątku.
                Console.WriteLine(e.Message);
            }


            Plan.listaLotow[count].dodajlot();
            Plan.listaLotow[count].wypisz();
        }
    }
}
