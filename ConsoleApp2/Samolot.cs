using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public  class Samolot
    {
           //TODO: Źle formatowany tekst ktoś Ci kiedyś w zespole za to jaja urwie ctrl + k a potem ctrl + d wszystkie łądnie formatuje jedynie nie usuwa spacji dlatego ich trzeba się pozbyć ręcznie
           //TODO: Czy nie mówiliśmy żeby zapoznać się z propertisami i w klasach modelu dla publicznych pól stosować propertisy?
           //TODO: Polecam korzystanie z typów wbudowanych w środowisko .NET tj. String Double DateTime, bo później jest łatwiej przy korzystanie i parsowaniem z np. z SQL do apki
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


