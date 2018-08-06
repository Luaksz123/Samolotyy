using System.Collections.Generic;

namespace Samoloty.Model
{
    public class ListaSamolotow
    {
        private List<Samolot> _samoloty=new List<Samolot>();
        public List<Samolot> samoloty
        {
            get { return _samoloty; }
            set {_samoloty = value; }
        }
    }
}
