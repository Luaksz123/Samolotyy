using System;
using System.Collections.Generic;
using System.Text;

namespace Samoloty.Entities
{
    public class Samolot
    {
        public Int32 ID { get; set; }
        public virtual Lot Loty { get; set; }
    }
}
