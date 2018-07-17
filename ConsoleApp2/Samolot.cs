using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public  class Samolot
    {

           
            public double Predkosc;
            public int liczbaMiejsc;
            public string nazwa;

             public Samolot()
            {
            
             }
                public Samolot(string Nazwa, int LiczbaMiejsc, int Predkosc)
            {
            this.nazwa = Nazwa;
            this.Predkosc = Predkosc;
            this.liczbaMiejsc = LiczbaMiejsc;

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


