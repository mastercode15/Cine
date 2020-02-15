using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Cine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int contador = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click0(object sender, RoutedEventArgs e)
        {
            if (MediaButton.Content == FindResource("Play"))
            {
                MediaButton.Content = FindResource("Stop");
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                MediaButton.Content = FindResource("Play");
                contador += 1;
                selection.Text = contador+" Asientos seleccionados";
            }
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (MediaButton1.Content == FindResource("Play"))
            {
                MediaButton1.Content = FindResource("Stop");
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                MediaButton1.Content = FindResource("Play");
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (MediaButton2.Content == FindResource("Play"))
            {
                MediaButton2.Content = FindResource("Stop");
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                MediaButton2.Content = FindResource("Play");
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            if (MediaButton3.Content == FindResource("Play"))
            {
                MediaButton3.Content = FindResource("Stop");
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                MediaButton3.Content = FindResource("Play");
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            if (MediaButton4.Content == FindResource("Play"))
            {
                MediaButton4.Content = FindResource("Stop");
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                MediaButton4.Content = FindResource("Play");
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            if (MediaButton5.Content == FindResource("Play"))
            {
                MediaButton5.Content = FindResource("Stop");
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                MediaButton5.Content = FindResource("Play");
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            if (MediaButton6.Content == FindResource("Play"))
            {
                MediaButton6.Content = FindResource("Stop");
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                MediaButton6.Content = FindResource("Play");
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            if (MediaButton7.Content == FindResource("Play"))
            {
                MediaButton7.Content = FindResource("Stop");
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                MediaButton7.Content = FindResource("Play");
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            if (MediaButton8.Content == FindResource("Play"))
            {
                MediaButton8.Content = FindResource("Stop");
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                MediaButton8.Content = FindResource("Play");
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            if (MediaButton9.Content == FindResource("Play"))
            {
                MediaButton9.Content = FindResource("Stop");
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                MediaButton9.Content = FindResource("Play");
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click10(object sender, RoutedEventArgs e)
        {
            if (MediaButton10.Content == FindResource("Play"))
            {
                MediaButton10.Content = FindResource("Stop");
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                MediaButton10.Content = FindResource("Play");
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click11(object sender, RoutedEventArgs e)
        {
            if (MediaButton11.Content == FindResource("Play"))
            {
                MediaButton11.Content = FindResource("Stop");
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                MediaButton11.Content = FindResource("Play");
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click12(object sender, RoutedEventArgs e)
        {
            if (MediaButton12.Content == FindResource("Play"))
            {
                MediaButton12.Content = FindResource("Stop");
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                MediaButton12.Content = FindResource("Play");
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click13(object sender, RoutedEventArgs e)
        {
            if (MediaButton13.Content == FindResource("Play"))
            {

                MediaButton13.Content = FindResource("Stop");
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                MediaButton13.Content = FindResource("Play");
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click14(object sender, RoutedEventArgs e)
        {
            if (MediaButton14.Content == FindResource("Play"))
            {
                MediaButton14.Content = FindResource("Stop");
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                MediaButton14.Content = FindResource("Play");
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Compra c = new Compra();
            c.Show();
            this.Hide();

        }
    }
}



