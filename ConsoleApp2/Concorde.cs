using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Concorde:Samolot
    {
        public Concorde()
        {
            this.nazwa = "Concorde";
            this.Predkosc = 2000;
            this.liczbaMiejsc = 20;
        }
    }
}
