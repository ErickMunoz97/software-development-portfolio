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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace GestionLibreria
{
    /// <summary>
    /// Interaction logic for Actualiza.xaml
    /// </summary>
    public partial class Actualiza : Window
    {
        SqlConnection miConexionSql;

        private int identificadorCliente;

        public Actualiza(int id)
        {
            InitializeComponent();
            identificadorCliente = id;
            string miConexion = ConfigurationManager.ConnectionStrings["GestionLibreria.Properties.Settings.GestionLibreriaConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string consulta = "UPDATE CLIENTE SET nombreCliente = @nombre WHERE idCliente = @idCliente";
            
            SqlCommand miSqlCommand = new SqlCommand(consulta,miConexionSql);
            miConexionSql.Open();

            miSqlCommand.Parameters.AddWithValue("@nombre", TextBox_Actualizar.Text);
            miSqlCommand.Parameters.AddWithValue("@idCliente", identificadorCliente);

            miSqlCommand.ExecuteNonQuery();
            miConexionSql.Close();

            this.Close();   
        }
    }
}
