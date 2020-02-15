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
    /// Lógica de interacción para Funciones.xaml
    /// </summary>
    public partial class Funciones : Window
    {
        SqlConnection sqlcon;
        public Funciones()
        {
            InitializeComponent();

            CargarPeliculas();
            CargarSala();
        }


        private void CargarPeliculas()
        {
            sqlcon = new SqlConnection(@"Data Source=FZAMBRANO-OPER;Initial Catalog=cine;Integrated Security=True");

            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            String query = "SELECT Nom_peli FROM Peliculas";
            SqlCommand sqlcmd = new SqlCommand(query, sqlcon);

            SqlDataReader reader = sqlcmd.ExecuteReader();

            while (reader.Read() == true)
            {
                CmbPeli.Items.Add(reader[0].ToString());
            }
            sqlcon.Close();
        }

        private void CargarSala() {
            sqlcon = new SqlConnection(@"Data Source=FZAMBRANO-OPER;Initial Catalog=cine;Integrated Security=True");
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            String query = "SELECT ID_sala FROM Sala";
            SqlCommand sqlcmd = new SqlCommand(query, sqlcon);

            SqlDataReader reader = sqlcmd.ExecuteReader();

            while (reader.Read() == true)
            {
                CmbSala.Items.Add(reader[0].ToString());
            }
            sqlcon.Close();
        }

            

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InsertarFuncion();
        }

        private void InsertarFuncion()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=FZAMBRANO-OPER;Initial Catalog=cine;Integrated Security=True");
            
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                          
                var aux = CmbSala.SelectedValue;
                String query = "INSERT INTO Funciones VALUES (" + TxtIdF.Text + ",'" + TxtFecha.Text + "','" + TxtHora1.Text + "','" + TxtIdioma.Text + "'," + TxtId.Text + "," + aux + ")";
                SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                int count = Convert.ToInt32(sqlcmd.ExecuteScalar());

                if (count == 1)
                {
                    MessageBox.Show("Función Agregada exitosamente");
                }
                else
                {
                    MessageBox.Show("Función Agregada exitosamente");
                }

                sqlcon.Close();
            
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }

        private void CmbPeli_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=FZAMBRANO-OPER;Initial Catalog=cine;Integrated Security=True");
                

                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                String query = "SELECT ID_peli FROM Peliculas WHERE Nom_peli = @nombre";
                SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                sqlcmd.Parameters.AddWithValue("@nombre", CmbPeli.SelectedValue);
                SqlDataReader registro = sqlcmd.ExecuteReader();

                if (registro.Read())
                {
                    TxtId.Text = registro["ID_peli"].ToString();

                }

                else
                {
                    MessageBox.Show("Película no encontrada");
                }

                sqlcon.Close();
            
        }
    }
}

