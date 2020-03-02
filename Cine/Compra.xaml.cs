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
        int idpeli, idfuncion, idsala, asiento, idboleto, idusuario, idmetpago;

        private void BtnImpBol_Click(object sender, RoutedEventArgs e)
        {            
            v1 = Txt1.Text;
            v2 = Txt2.Text;
            v3 = Txt3.Text;
            v4 = Txt4.Text;
            v5 = Txt5.Text;
            v6 = Txt6.Text;
            v7 = TxtValTot.Text;
            v8 = TxtUsuario.Text;
            v9 = (string)CmbMetPago.SelectedValue;
            v10 = Txt7.Text;
            v11 = Txt8.Text;
            v12 = TxtValTot.Text;
            generarBoleto();
        }
        public static string v1;
        public static string v2;
        public static string v3;
        public static string v4;
        public static string v5;
        public static string v6;
        public static string v7;
        public static string v8;
        public static string v9;
        public static string v10;
        public static string v11;
        public static string v12;
        public Compra()
        {
            InitializeComponent();
            boleto = new Boleto();
            usuario = new WndLogin();
            txtbolTot.Text = MainWindow.cont.ToString();
            TxtValTot.Text = (MainWindow.cont * 5).ToString();
            CargarPago();
            
        }

        public void cargarDatos()
        {
            //Txt1.Text = MainWindow.v1;
            //Txt2.Text = MainWindow.v2;
            //Txt3.Text = MainWindow.v3;
            //Txt4.Text = MainWindow.v4;
            //Txt5.Text = MainWindow.v5;
            //Txt6.Text = MainWindow.v6;
            //Txt7.Text = MainWindow.v7;
            //Txt8.Text = MainWindow.v8;
            //TxtIds.Text = MainWindow.v9;
        }


        private void CmbMetPago_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CargarPago()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=FZAMBRANO-OPER;Initial Catalog=cine;Integrated Security=True");

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
        private void BtnConfCompra_Click(object sender, RoutedEventArgs e)
        {
            cargarDatos();
            generarCompra();
            
        }

        private void generarCompra()
        {
            IDMetodoPago();
            String q;
            String query;
            SqlConnection sqlcon = new SqlConnection(@"Data Source=FZAMBRANO-OPER;Initial Catalog=cine;Integrated Security=True");
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                //query = "Insert into Compras values (@idcompra,@totalbol,@fk_id_usuario,@fk_id_met_pago,@valtotal)";
                query = "INSERT INTO Compras VALUES (@idcompra,@totalbol,1,@fk_id_met_pago,@valtotal)";
                SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                sqlcmd.Parameters.AddWithValue("@idcompra", Convert.ToInt32(txtIdcompra.Text));
                sqlcmd.Parameters.AddWithValue("@totalbol", txtbolTot.Text);
                //sqlcmd.Parameters.AddWithValue("@fk_id_usuario", Convert.ToInt32(TxtIds.Text));
                sqlcmd.Parameters.AddWithValue("@fk_id_met_pago", Convert.ToInt32(LblIdMet.Text));
                sqlcmd.Parameters.AddWithValue("@valtotal", TxtValTot.Text);
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
            //decimal costoboleto = 10;
            SqlConnection sqlcon = new SqlConnection(@"Data Source=FZAMBRANO-OPER;Initial Catalog=cine;Integrated Security=True");
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            //try
            //{
                String query = "insert into Boleto values (22,@fk_id_compra,2,3,2,1,@costoboleto)";
            //String query = "insert into Boleto values (1,@fk_id,4,@fk_id_sala,2,@fk_id_peli,@costoboleto)";
            SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                //sqlcmd.Parameters.AddWithValue("@idboleto", 1);
                sqlcmd.Parameters.AddWithValue("@costoboleto", TxtValTot.Text);
                sqlcmd.Parameters.AddWithValue("@fk_id_compra", txtIdcompra.Text);
                //sqlcmd.Parameters.AddWithValue("@fk_id_funcion", Txt7.Text);
                sqlcmd.Parameters.AddWithValue("@fk_id_sala", Txt6.Text);
                //sqlcmd.Parameters.AddWithValue("@fk_id_asiento",Convert.ToInt32(2));
                //sqlcmd.Parameters.AddWithValue("@fk_id_peli", Txt8.Text);
                int count = Convert.ToInt32(sqlcmd.ExecuteScalar());
                if (count == 1)
                {
                    boleto.Show();
                    this.Hide();
                    sqlcon.Close();
                } else
                {
                    boleto.Show();
                    this.Hide();
                    sqlcon.Close();
                }
            //} catch (Exception error)
            //{
            //    MessageBox.Show(error.Message);
            //    sqlcon.Close();
            //}
        }

        
        private void IDMetodoPago()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=FZAMBRANO-OPER;Initial Catalog=cine;Integrated Security=True");

            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            String query = "SELECT ID_met_pago_compra FROM Metodo_pago_compra where Nom_met_pago_compra like'"+CmbMetPago.SelectedValue+"'";
            SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
            //sqlcmd.Parameters.AddWithValue("@nommetpago", CmbMetPago.SelectedValue);
            SqlDataReader registro = sqlcmd.ExecuteReader();
            if (registro.Read())
            {
                LblIdMet.Text = registro["ID_met_pago_compra"].ToString();
            }
            sqlcon.Close();
        }
        
    }
}
