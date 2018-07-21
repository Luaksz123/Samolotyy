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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SamolotyWpf
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
  
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DodajSamolot_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            DodajSamolot wnd = new DodajSamolot();
            wnd.Show();
        }

        private void DodajLot_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            DodajLot wnd = new DodajLot();
            wnd.Show();
        }

      

        private void Wyswietl_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Wyswietl wnd = new Wyswietl();
            wnd.Show();
        }

        private void Rezerwuj_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            rezerwuj wnd = new rezerwuj();
            wnd.Show();
        }
    }
}
