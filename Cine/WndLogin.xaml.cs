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
    /// Lógica de interacción para WndLogin.xaml
    /// </summary>
    public partial class WndLogin : Window
    { 
       
        public WndLogin()
        {
            InitializeComponent();  
            
        }

        public static string id;

        private void InicioSesion(object sender, RoutedEventArgs e)
        {
            ID_Usuario();
         
            SqlConnection sqlcon = new SqlConnection(@"Data Source=FZAMBRANO-OPER;Initial Catalog=cine;Integrated Security=True");

            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                String query = "SELECT COUNT(1) FROM Usuario WHERE Nom_usuario=@correo AND pwd_usuario=@pwd";
                SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.Parameters.AddWithValue("@correo", textEmail.Text);
                sqlcmd.Parameters.AddWithValue("@pwd", textPwd.Password);
                int count = Convert.ToInt32(sqlcmd.ExecuteScalar());



                if (count == 1)
                {
                    id = txtId.Text;
                    Home home = new Home();
                    home.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
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
        public void ID_Usuario()
        {           
            SqlConnection sqlcon = new SqlConnection(@"Data Source=FZAMBRANO-OPER;Initial Catalog=cine;Integrated Security=True");
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                String query = "SELECT ID_usuario FROM Usuario WHERE Nom_usuario=@correo AND pwd_usuario=@pwd";
                SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                sqlcmd.Parameters.AddWithValue("@correo", textEmail.Text);
                sqlcmd.Parameters.AddWithValue("@pwd", textPwd.Password);
                SqlDataReader registro = sqlcmd.ExecuteReader();
                if (registro.Read())
                {
                    txtId.Text = registro["ID_usuario"].ToString();
                }
                
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }


        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
        