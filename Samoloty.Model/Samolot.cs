namespace Samoloty.Model
{
    public class Samolot
    {
        //TODO: Polecam korzystanie z typów wbudowanych w środowisko .NET tj. String Double DateTime, bo później jest łatwiej przy korzystanie i parsowaniem z np. z SQL do apki
        private double _predkosc;
        public double predkosc
        {
            get { return _predkosc; }
            set { _predkosc = value; }
        }
        //TODO: Czemu liczba miejsca public występuje podwójnie????
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


