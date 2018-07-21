using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SamolotyKonsola;


namespace SamolotyWpf
{
    /// <summary>
    /// Logika interakcji dla klasy DodajLot.xaml
    /// </summary>
    public partial class DodajLot : Window
    {
        //TODO: Mówiliśmy że nie musisz się bawić przy dodawaniu kontrolek, ale prosto by mogły być ;)

        public List<Samolot> Lista = new List<Samolot>();

        public DodajLot()
        {
            InitializeComponent();
        }

        private void DodajLotCofnij_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Tak cały czas w każdej klasie jak będziesz dawał hide to Ci miejsca w pamieci braknie po czasie... jeśli Garbage Collector nie zaskoczy
            this.Hide();
           MainWindow wnd = new MainWindow();
            wnd.Show();
        }

       

        private void DodajLot_Load(object sender, EventArgs e)
        {

            Lista.Add(new Samolot() { nazwa = "Boeing", predkosc = 1000, liczbaMiejsc = 20 });
            this.DodajLotSamoloty.ItemsSource=Lista;
           
        }

       
    }
}
