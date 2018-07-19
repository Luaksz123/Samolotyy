using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samoloty
{
    public class Samolot
    {
        //TODO: Źle formatowany tekst ktoś Ci kiedyś w zespole za to jaja urwie ctrl + k a potem ctrl + d wszystkie łądnie formatuje jedynie nie usuwa spacji dlatego ich trzeba się pozbyć ręcznie
        //TODO: Czy nie mówiliśmy żeby zapoznać się z propertisami i w klasach modelu dla publicznych pól stosować propertisy?
        //TODO: Polecam korzystanie z typów wbudowanych w środowisko .NET tj. String Double DateTime, bo później jest łatwiej przy korzystanie i parsowaniem z np. z SQL do apki

        private double _predkosc;

        public double predkosc
        {
            get { return _predkosc; }
            set { _predkosc = value; }
        }

        public int liczbaMiejsc;
        private int _iczbaMiejsc;

        public int iczbaMiejsc
        {
            get { return _iczbaMiejsc; }
            set { _iczbaMiejsc = value; }
        }

        public string nazwa;

        public Samolot()
        {

        }
       

    }
}


