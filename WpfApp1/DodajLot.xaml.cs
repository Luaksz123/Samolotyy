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


namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy DodajLot.xaml
    /// </summary>
    public partial class DodajLot : Window
    {

        public List<ConsoleApp2.Samolot> Lista = new List<ConsoleApp2.Samolot>();

        public DodajLot()
        {
            InitializeComponent();
        }

        private void DodajLotCofnij_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
           MainWindow wnd = new MainWindow();
            wnd.Show();
        }

       

        private void DodajLot_Load(object sender, EventArgs e)
        {

            Lista.Add(new ConsoleApp2.Samolot() { nazwa = "Boeing", Predkosc = 1000, liczbaMiejsc = 20 });
            this.DodajLotSamoloty.ItemsSource=Lista;
           
        }

       
    }
}
