using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class PlanLotu
    {
        public List<Lot> listaLotow = new List<Lot>();

    
        public PlanLotu()
        {
        }
        public void dodaj()
        {
           Lot a = new Lot();
           listaLotow.Add(a);
        }
    }
}
