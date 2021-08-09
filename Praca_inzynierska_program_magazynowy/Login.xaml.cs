using System;
using System.Collections.Generic;
using System.Data;
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
using System.Data.SqlClient;

namespace Praca_inzynierska_program_magazynowy
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        List<Users> users = new List<Users>();
        public Login()
        {
          
            InitializeComponent();
           
          
        }


        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-D6IH4BR\SQLEXPRESS;Initial Catalog=BazaDanychMagazyn;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT (*) from Uzytkownik Where login = '" + txtUserName.Text + "' AND haslo = '" + txtPassword.Password + "' ", sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows[0][0].ToString() == "1")
            {
                 this.Hide();
                new MainWindow().Show();
            }
            else
            {
                MessageBox.Show("dane logowania są niepoprawne");
            }
        }
    }
}

