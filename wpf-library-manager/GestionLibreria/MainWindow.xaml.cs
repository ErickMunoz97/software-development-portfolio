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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace GestionLibreria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
                                                                                                                                      
            string miConexion = ConfigurationManager.ConnectionStrings["GestionLibreria.Properties.Settings.GestionLibreriaConnectionString"].ConnectionString;
            
            miConexionSql = new SqlConnection(miConexion);

            muestraClientes();
            muestraTodosPedidos();
        }

        private void muestraClientes()
        {
            string consulta = "SELECT * FROM CLIENTE";
            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql) ;

            using (miAdaptadorSql)
            {
                DataTable clientesTabla = new DataTable();
                miAdaptadorSql.Fill(clientesTabla);

                listaClientes.DisplayMemberPath = "nombreCliente";
                listaClientes.SelectedValuePath = "idCliente";
                listaClientes.ItemsSource = clientesTabla.DefaultView;
            }
        }

        private void muestraInfoPedido()
        {
            string consulta = "SELECT * FROM PEDIDO WHERE idCliente = @idCliente";
            SqlCommand sqlComando = new SqlCommand(consulta, miConexionSql);
            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(sqlComando);

            using (miAdaptadorSql)
            {
                sqlComando.Parameters.AddWithValue("@idCliente", listaClientes.SelectedValue);
                DataTable pedidoTabla = new DataTable();
                miAdaptadorSql.Fill(pedidoTabla);

                infoPedido.DisplayMemberPath = "formaPago";
                infoPedido.SelectedValuePath = "idPedido";
                infoPedido.ItemsSource = pedidoTabla.DefaultView;
            }
        }




        private void muestraTodosPedidos()
        {
            string consulta = "SELECT *, CONCAT (idCliente , ' ', fechaPedido, ' ', formaPago ) AS INFO FROM PEDIDO";
            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);
            using (miAdaptadorSql)
            {
                DataTable pedidosTabla = new DataTable();
                miAdaptadorSql.Fill(pedidosTabla);
                todosPedidos.DisplayMemberPath = "INFO";
                todosPedidos.SelectedValuePath = "IdPedido";
                todosPedidos.ItemsSource = pedidosTabla.DefaultView;
            }
        }


        private void MouseDoubleClick_MuestraInfo(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Seleccionaste un cliente");
            muestraInfoPedido();

        }   

        private void Button_EliminaPedido(object sender, RoutedEventArgs e)
        {
            string consulta = "DELETE FROM PEDIDO WHERE IdPedido = @PEDIDOID";
            SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
            miConexionSql.Open();
            miSqlCommand.Parameters.AddWithValue("@PEDIDOID", todosPedidos.SelectedValue);
            miSqlCommand.ExecuteNonQuery();
            miConexionSql.Close();

            muestraTodosPedidos();
        }

        private void Button_InsertaCliente(object sender, RoutedEventArgs e)
        {
            string consulta = "INSERT INTO CLIENTE (nombreCliente) VALUES (@nombre)";
            SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
            miConexionSql.Open();
            miSqlCommand.Parameters.AddWithValue("@nombre", insertaCliente.Text);
            miSqlCommand.ExecuteNonQuery();
            miConexionSql.Close();

            muestraClientes();
        }

        private void Button_EliminaCliente(object sender, RoutedEventArgs e)
        {
            string consulta = "DELETE FROM CLIENTE WHERE nombreCliente = @nombre ";
            SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
            miConexionSql.Open();
            miSqlCommand.Parameters.AddWithValue("@nombre", insertaCliente.Text);
            miSqlCommand.ExecuteNonQuery();
            miConexionSql.Close();

            muestraClientes();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Actualiza ventanaActualizar = new Actualiza((int)listaClientes.SelectedValue);
            ventanaActualizar.Show();
            try
            {
                string consulta = "SELECT nombreCliente FROM CLIENTE WHERE idCliente=@ClId";

                SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(miSqlCommand);
                using (miAdaptadorSql)
                {

                    miSqlCommand.Parameters.AddWithValue("ClId", listaClientes.SelectedValue);

                    DataTable clientesTabla = new DataTable(); ;
                    miAdaptadorSql.Fill(clientesTabla);
                    ventanaActualizar.TextBox_Actualizar.Text = clientesTabla.Rows[0]["nombreCliente"].ToString();
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString());
            }
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            muestraClientes();
        }

        private void listaClientes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            muestraInfoPedido();
        }




        SqlConnection miConexionSql;


    }
}
