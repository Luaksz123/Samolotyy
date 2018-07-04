using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
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
                  
                    Plan.listaLotow[count].dodajLot(new Boeing());
                }
                if (tmp == 2)
                {
                    Plan.listaLotow[count].dodajLot(new Concorde());
                }
                //dsada
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }


            Plan.listaLotow[count].dodajlot();
            Plan.listaLotow[count].wypisz();
        }
    }
}
