using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Samoloty.Entitiesss
{
   public class Samoloty
    {
        [Key]
        public Int32 ID { get; set; }
        public String Nazwa { get; set; }
    }
}
