using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Cine
{
    /// <summary>
    /// Lógica de interacción para Compra.xaml
    /// </summary>
    public partial class Compra : Window
    {
        Boleto boleto;
        WndLogin usuario;
        int idpeli, idfuncion, idsala, idasiento, idboleto, idusuario, idmetpago;

        private void BtnImpBol_Click(object sender, RoutedEventArgs e)
        {
            generarBoleto();
        }

        public Compra(int idp, int idf, int ids, int ida)
        {
            InitializeComponent();
            boleto = new Boleto();
            usuario = new WndLogin();
            CargarVentana();
            CargarMetodoPago();
            idpeli = idp;
            idfuncion = idf;
            idsala = ids;
            idasiento = ida;
        }

        private void BtnConfCompra_Click(object sender, RoutedEventArgs e)
        {
            generarCompra();
        }

        private void generarCompra()
        {
            idusuario = usuario.ID_Usuario();
            //IDMetodoPago();
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-8CSIPAS\TEW_SQLEXPRESS;Initial Catalog=cine;Integrated Security=True");
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                String query = "insert into Compras values (@idcompra,@totalbol,@valtotal,@fk_id_usuario,@fk_id_met_pago)";
                SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                sqlcmd.Parameters.AddWithValue("@idcompra", 1);
                sqlcmd.Parameters.AddWithValue("@totalbol", txtbolTot.Text);
                sqlcmd.Parameters.AddWithValue("@valtotal", 10);
                sqlcmd.Parameters.AddWithValue("@fk_id_usuario", 1);
                sqlcmd.Parameters.AddWithValue("@fk_id_met_pago", 1);
                int count = Convert.ToInt32(sqlcmd.ExecuteScalar());

                if (count == 1)
                {
                    MessageBox.Show("Compra exitosa");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                sqlcon.Close();
            }
        }
        private void generarBoleto()
        {
            decimal costoboleto = 10;
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-8CSIPAS\TEW_SQLEXPRESS;Initial Catalog=cine;Integrated Security=True");
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            try
            {
                String query = "insert into boleto values (@idboleto,@costoboleto,@fk_id_compra,@fk_id_funcion,@fk_id_sala,@fk_id_asiento,@fk_id_peli)";
                SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                sqlcmd.Parameters.AddWithValue("@idboleto",1);
                sqlcmd.Parameters.AddWithValue("@costoboleto", costoboleto);
                sqlcmd.Parameters.AddWithValue("@fk_id_compra", txtIdcompra.Text);
                sqlcmd.Parameters.AddWithValue("@fk_id_funcion", idfuncion);
                sqlcmd.Parameters.AddWithValue("@fk_id_sala", idsala);
                sqlcmd.Parameters.AddWithValue("@fk_id_asiento", idasiento);
                sqlcmd.Parameters.AddWithValue("@fk_id_peli", idpeli);
                int count = Convert.ToInt32(sqlcmd.ExecuteScalar());
                if (count == 1)
                {
                    boleto.Show();
                    this.Hide();
                    sqlcon.Close();
                } else
                {
                    MessageBox.Show("Verificar datos");
                    sqlcon.Close();
                }
            } catch (Exception error)
            {
                MessageBox.Show(error.Message);
                sqlcon.Close();
            }
        }

        private void CargarMetodoPago()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-8CSIPAS\TEW_SQLEXPRESS;Initial Catalog=cine;Integrated Security=True");

            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            String query = "SELECT Nom_met_pago_compra FROM Metodo_pago_compra";
            SqlCommand sqlcmd = new SqlCommand(query, sqlcon);

            SqlDataReader reader = sqlcmd.ExecuteReader();

            while (reader.Read() == true)
            {
                CmbMetPago.Items.Add(reader[0].ToString());
            }
            sqlcon.Close();
        }
        private void IDMetodoPago()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-8CSIPAS\TEW_SQLEXPRESS;Initial Catalog=cine;Integrated Security=True");

            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            String query = "SELECT ID_met_pago_compra FROM Metodo_pago_compra where Nom_met_pago_compra like @nommetpago";
            SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
            sqlcmd.Parameters.AddWithValue("@nommetpago", CmbMetPago.SelectedValue);
            SqlDataReader registro = sqlcmd.ExecuteReader();
            if (registro.Read())
            {
                idmetpago = Convert.ToInt32(registro["ID_met_pago_compra"]);
            }
            sqlcon.Close();
        }
        private void CargarVentana()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-8CSIPAS\TEW_SQLEXPRESS;Initial Catalog=cine;Integrated Security=True");
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                String query = "SELECT Nom_usuario FROM usuario where ID_usuario = 1";
                SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                SqlDataReader registro = sqlcmd.ExecuteReader();
                if (registro.Read()) 
                { 
                    txtUsuario.Text = registro["Nom_usuario"].ToString();
                }
                //txtValTot.Text = (Convert.ToInt32(txtbolTot.Text) * 5).ToString();
                sqlcon.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
                sqlcon.Close();
            }
        }
    }
}
