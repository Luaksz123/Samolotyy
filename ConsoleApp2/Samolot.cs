using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Samolot
    {
        
            protected double Predkosc;
            protected int liczbaMiejsc;
            protected string nazwa;

             public Samolot()
            {

            }
            public virtual double getPredkosc()
            {
                return Predkosc;
            }
            public virtual int getliczbaMiejsc()
            {
                return liczbaMiejsc;
            }
             public virtual string getNazwa()
             {
            return nazwa;
              }
    }
    }


