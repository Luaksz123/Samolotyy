﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samoloty
{
    class PlanLotu
    {
        public List<Lot> listaLotow = new List<Lot>();

    
        public PlanLotu()
        {
        }
        //TODO: Zastanawiam się po co ta metoda skoro listaLotow jest publiczna nie odwołujesz się do bazy ani nic? przeciez można dać bezpośrednio na obiekcie listalotow.add()
        // Racja poprawione
       
    }
}
