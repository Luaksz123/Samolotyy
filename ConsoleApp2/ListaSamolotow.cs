using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samoloty
{
    class ListaSamolotow
    {

        private List<Samolot> _samoloty=new List<Samolot>();

        public List<Samolot> samoloty
        {
            get { return _samoloty; }
            set { _samoloty = value; }
        }

    }

 
}
