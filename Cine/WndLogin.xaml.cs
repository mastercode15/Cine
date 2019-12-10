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
    /// Lógica de interacción para WndLogin.xaml
    /// </summary>
    public partial class WndLogin : Window
    {
        public WndLogin()
        {
            InitializeComponent();
        }

        private void InicioSesion(object sender, RoutedEventArgs e)
        {
            PeliculasWindows loginS = new PeliculasWindows();
            loginS.Show();
            this.Close();
        }
    }
}
