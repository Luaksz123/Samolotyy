using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Boeing:Samolot
    {
        public Boeing()
        {
            this.nazwa = "Boeing";
            this.Predkosc = 1000;
            this.liczbaMiejsc = 10;
        }
    }
}
