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
    /// Lógica de interacción para InsertarPelicula.xaml
    /// </summary>
    public partial class InsertarPelicula : Window
    {
        public InsertarPelicula()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=FZAMBRANO-OPER;Initial Catalog=cine;Integrated Security=True");

            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                String query = "INSERT INTO Peliculas VALUES (" + TxtId.Text + ",'" + TxtName.Text + "','" + TxtDureacion.Text + "','" + TxtAnio.Text + "','" + TxtSinopsis.Text + "','" + TxtClasificacion.Text + "','" + TxtGenero.Text +"')";
                SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                int count = Convert.ToInt32(sqlcmd.ExecuteNonQuery());

                if (count == 1)
                {
                    MessageBox.Show("Pelicula Agregada exitosamente");
                }
                else
                {
                    MessageBox.Show("Película no agregada");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Home back = new Home();
            back.Show();
            this.Close();
        }
    }
}
