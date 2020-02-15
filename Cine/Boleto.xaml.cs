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
    /// Lógica de interacción para Boleto.xaml
    /// </summary>
    public partial class Boleto : Window
    {
        public Boleto()
        {
            InitializeComponent();
            Conexion();

        }

        public void Conexion()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=FZAMBRANO-OPER;Initial Catalog=cine;Integrated Security=True");


            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            String query = "SELECT P.Nom_peli, F.Idioma_funcion, F.Fecha_funcion, F.Hora_funcion, S.Tipo_de_sala, S.ID_sala, M.Nom_met_pago_compra, C.valor_total FROM Boleto B, Peliculas P, Funciones F, Sala S, Metodo_pago_compra M, Compras C " +
                "WHERE P.ID_peli=B.FK_ID_peli AND F.ID_funcion = B.FK_ID_funcion AND S.ID_sala = B.FK_ID_sala AND C.ID_compra = B.FK_ID_sala AND M.ID_met_pago_compra = C.FK_ID_met_pago";
            SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
            SqlDataReader registro1 = sqlcmd.ExecuteReader();

            if (registro1.Read())

                TxtCliente.Text = "Nicole Zambrano";
            TxtPelicula.Text = registro1["Nom_peli"].ToString();
            Txtidioma.Text = registro1["Idioma_funcion"].ToString();
            TxtFecha.Text = registro1["Fecha_funcion"].ToString();
            TxtHora.Text = registro1["Hora_funcion"].ToString();
            TxtDefinicion.Text = registro1["Tipo_de_sala"].ToString();
            TxtSala.Text = registro1["ID_sala"].ToString();
            TxtTotal.Text = registro1["Nom_met_pago_compra"].ToString();
            TxtPago.Text = registro1["valor_total"].ToString();
        }

    }


}


