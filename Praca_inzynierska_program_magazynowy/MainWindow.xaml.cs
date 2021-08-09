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
using System.IO;
using Microsoft.Win32;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;


namespace Praca_inzynierska_program_magazynowy
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-D6IH4BR\SQLEXPRESS;Initial Catalog=BazaDanychMagazyn;Integrated Security=True");
        SqlDataAdapter adpt;
        DataTable dt;
        List<WZWystawienie> wZWystawienie = new List<WZWystawienie>();
        private bool wZZPlacuPrzycisk = true;
        private bool przyjecieNaPlacPrzycisk = false;

        public MainWindow()
        {
            InitializeComponent();
            PokazGrid();
        }
  

        public void PokazGrid()
        {
            adpt = new SqlDataAdapter("select* from WZWystawienie", sqlcon);
            dt = new DataTable();
            adpt.Fill(dt);
            GenerowanieKolumn.DataContext = dt;
        }

        private void AktualizacjaListyWZWysylka()
        {
            GenerowanieKolumn.ItemsSource = null;
            GenerowanieKolumn.ItemsSource = wZWystawienie;
        }
        private void WZZPlacu_Click(object sender, RoutedEventArgs e)
        {
            SettingToFalse();
            wZZPlacuPrzycisk = true;


        }

        private void PrzyjecieNaPlac_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Zestawienia_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Stany_Click(object sender, RoutedEventArgs e)
        {

        }

        private void WystawWZ_Click(object sender, RoutedEventArgs e)
        {
            PokazGrid();

        }

        private void UsunWZ_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Odswiez_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Zmien_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Drukuj_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GenerowanieKolumn_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SettingToFalse() // Zmiana na false potrzebne do zmiany nazw w glownym oknie
        {
            wZZPlacuPrzycisk = false;
            przyjecieNaPlacPrzycisk = false;

        }


        private void AutoGenerowanieKolumny(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyDescriptor is PropertyDescriptor descriptor)
            {
                e.Column.Header = descriptor.DisplayName ?? descriptor.Name;
            }
        }


    }
}
