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
            Plan.tab[LicznikLotow].zajety = true;
            Console.WriteLine("Wybiez samolot \n 1 Boeing \n 2 Concorde");
           
            tmp=int.Parse(Console.ReadLine());
            if (tmp==1)
            {
                Console.WriteLine("Wybiez samolot \n 1 Boeing \n 2 Concorde");
                Plan.tab[LicznikLotow] = new Lot(new Boeing());
            }
            if (tmp == 2)
            {
                Plan.tab[LicznikLotow] = new Lot(new Concorde());
            }
           
            Plan.tab[LicznikLotow].dodajlot();
            Plan.tab[LicznikLotow].wypisz();
        }
    }
}
