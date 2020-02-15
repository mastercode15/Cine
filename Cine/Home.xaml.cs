using System;
using System.Collections.Generic;
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
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
            TxtIds.Text = WndLogin.id;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PeliculasWindows ver = new PeliculasWindows();
            ver.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            InsertarPelicula ins = new InsertarPelicula();
            ins.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Funciones funcion = new Funciones();
            funcion.Show();
            this.Hide();
        }
    }
}
