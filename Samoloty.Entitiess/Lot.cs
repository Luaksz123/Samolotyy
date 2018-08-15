using System;
using System.Collections.Generic;
using System.Text;

namespace Samoloty.Entities
{
    public class Lot
    {
        public Int32 ID { get; set; }
        public String Rodzaj { get; set; }
        public Int32 NrLotu { get; set; }
        public Single MyProperty { get; set; }
        public Single CzasTrwania { get; set; }
        public ICollection<Samolot> Samolot { get; set; }
    }
}
