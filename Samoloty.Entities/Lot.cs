using System;
using System.Collections.Generic;
using System.Text;

namespace Samoloty.Entities
{
    public class Lot
    {
        public Int32 ID { get; set; }
        public virtual Samolot Samoloty { get; set; }
    }
}
