using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class PlanLotu
    {
       public Lot []tab;

        public PlanLotu()
        {
            tab = new Lot[100];
            for (int i = 0; i < 100; i++)
                tab[i] = new Lot();
        }
    }
}
