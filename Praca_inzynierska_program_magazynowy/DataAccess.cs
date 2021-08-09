using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Praca_inzynierska_program_magazynowy
{
    class DataAccess
    {
       //public static List<WZWystawienie>CzytajWZWystawienie()
       // {
           
       //     SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-D6IH4BR\SQLEXPRESS;Initial Catalog=BazaDanychMagazyn;Integrated Security=True");
       //     SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT (*) from Uzytkownik Where login = '" + txtUserName.Text + "' AND haslo = '" + txtPassword.Password + "' ", sqlcon);
       //     DataTable dtbl = new DataTable();
       //     sda.Fill(dtbl);
       // }
        private static string LadowaniePolaczeniaDlaStringa(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
