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
    /// Lógica de interacción para s.xaml
    /// </summary>
    public partial class PeliculasWindows : Window
    {
        int idpeli, idfuncion, idsala;
        SqlDataReader registro;
        SqlDataReader registro1;
        public PeliculasWindows()
        {
            InitializeComponent();

            CargarPeliculas();
        }


        private void CargarPeliculas()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-8CSIPAS\TEW_SQLEXPRESS;Initial Catalog=cine;Integrated Security=True");

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void CmbPeli_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-8CSIPAS\TEW_SQLEXPRESS;Initial Catalog=cine;Integrated Security=True");


            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            String query = "SELECT P.ID_peli, P.Nom_peli, P.Dur_peli, P.Anio_peli, P.Sip_peli, P.Clasif_peli, P.Gen_peli, F.Hora_funcion FROM Peliculas P, Funciones F WHERE P.Nom_peli = @nombre AND P.ID_peli = F.FK_ID_peli";
            SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
            sqlcmd.Parameters.AddWithValue("@nombre", CmbPeli.SelectedValue);
            registro = sqlcmd.ExecuteReader();

            if (registro.Read())
            {
                idpeli = Convert.ToInt32(registro["ID_peli"]);
                TxtId.Text = registro["ID_peli"].ToString();
                TxtDuracion.Text = registro["Dur_peli"].ToString();
                TxtAnio.Text = registro["Anio_peli"].ToString();
                TxtSinopsis.Text = registro["Sip_peli"].ToString();
                TxtClasificacion.Text = registro["Clasif_peli"].ToString();
                TxtGenero.Text = registro["Gen_peli"].ToString();
                while(registro.Read() == true)
                {
                    CmbFuncion.Items.Add(registro[7].ToString());
                }
                
            }

            else
            {
                MessageBox.Show("Película no encontrada");
            }

            sqlcon.Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-8CSIPAS\TEW_SQLEXPRESS;Initial Catalog=cine;Integrated Security=True");


            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            String query = "SELECT F.ID_funcion, F.Idioma_funcion, F.Fecha_funcion, S.Tipo_de_sala, S.ID_sala FROM Funciones F, Sala S WHERE f.Hora_funcion = @hora AND S.ID_sala = F.FK_ID_sala";
            SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
            sqlcmd.Parameters.AddWithValue("@hora", CmbFuncion.SelectedValue);
            registro1 = sqlcmd.ExecuteReader();

            if (registro1.Read())
            {
                idfuncion = Convert.ToInt32(registro1["ID_funcion"]);
                idsala = Convert.ToInt32(registro1["ID_sala"]);
                TxtFecha.Text = registro1["Fecha_funcion"].ToString();
                TxtIdioma.Text = registro1["Idioma_funcion"].ToString();
                TxtSala.Text = registro1["ID_sala"].ToString();
                TxtDefinicion.Text = registro1["Tipo_de_sala"].ToString();
            }

            else
            {
                MessageBox.Show("Película no encontrada");
            }

            sqlcon.Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Home h2 = new Home();
            h2.Show();
            this.Hide();
        }
        private void SelecionarAsiento(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(idpeli,idfuncion,idsala);
            main.Show();
            this.Close();
        }
    }
}
