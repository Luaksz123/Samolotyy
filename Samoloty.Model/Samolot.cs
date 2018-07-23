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
        // Mój błąd przyznaję się bez bicia
        // Poprawione
        
        private int _LiczbaMiejsc;
        public int LiczbaMiejsc
        {
            get { return _LiczbaMiejsc; }
            set { _LiczbaMiejsc = value; }
        }
        public string nazwa;
        public Samolot()
        {

        }
    }
}


