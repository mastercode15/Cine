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
        string seleccionado = @"C:\Users\Sebastian\OneDrive\Escritorio\prototipo_cine\Cine\Images\asientoSeleccionado.png";
        string deseleccionado = @"C:\Users\Sebastian\OneDrive\Escritorio\prototipo_cine\Cine\Images\asientoDeseleccionado.png";
        int contador = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click0(object sender, RoutedEventArgs e)
        {
            if (img0.Source.ToString() == deseleccion1.Source.ToString())
            {
                img0.Source = new BitmapImage(new Uri(seleccionado));
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                img0.Source = new BitmapImage(new Uri(deseleccionado));
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (img1.Source.ToString() == deseleccion1.Source.ToString())
            {
                img1.Source = new BitmapImage(new Uri(seleccionado));
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                img1.Source = new BitmapImage(new Uri(deseleccionado));
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (img2.Source.ToString() == deseleccion1.Source.ToString())
            {
                img2.Source = new BitmapImage(new Uri(seleccionado));
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                img2.Source = new BitmapImage(new Uri(deseleccionado));
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            if (img3.Source.ToString() == deseleccion1.Source.ToString())
            {
                img3.Source = new BitmapImage(new Uri(seleccionado));
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                img3.Source = new BitmapImage(new Uri(deseleccionado));
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            if (img4.Source.ToString() == deseleccion1.Source.ToString())
            {
                img4.Source = new BitmapImage(new Uri(seleccionado));
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                img4.Source = new BitmapImage(new Uri(deseleccionado));
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            if (img5.Source.ToString() == deseleccion1.Source.ToString())
            {
                img5.Source = new BitmapImage(new Uri(seleccionado));
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                img5.Source = new BitmapImage(new Uri(deseleccionado));
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            if (img6.Source.ToString() == deseleccion1.Source.ToString())
            {
                img6.Source = new BitmapImage(new Uri(seleccionado));
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                img6.Source = new BitmapImage(new Uri(deseleccionado));
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            if (img7.Source.ToString() == deseleccion1.Source.ToString())
            {
                img7.Source = new BitmapImage(new Uri(seleccionado));
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                img7.Source = new BitmapImage(new Uri(deseleccionado));
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            if (img8.Source.ToString() == deseleccion1.Source.ToString())
            {
                img8.Source = new BitmapImage(new Uri(seleccionado));
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                img8.Source = new BitmapImage(new Uri(deseleccionado));
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            if (img9.Source.ToString() == deseleccion1.Source.ToString())
            {
                img9.Source = new BitmapImage(new Uri(seleccionado));
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                img9.Source = new BitmapImage(new Uri(deseleccionado));
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click10(object sender, RoutedEventArgs e)
        {
            if (img10.Source.ToString() == deseleccion1.Source.ToString())
            {
                img10.Source = new BitmapImage(new Uri(seleccionado));
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                img10.Source = new BitmapImage(new Uri(deseleccionado));
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click11(object sender, RoutedEventArgs e)
        {
            if (img11.Source.ToString() == deseleccion1.Source.ToString())
            {
                img11.Source = new BitmapImage(new Uri(seleccionado));
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                img11.Source = new BitmapImage(new Uri(deseleccionado));
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click12(object sender, RoutedEventArgs e)
        {
            if (img12.Source.ToString() ==deseleccion1.Source.ToString())
            {
                img12.Source = new BitmapImage(new Uri(seleccionado));
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                img12.Source = new BitmapImage(new Uri(deseleccionado));
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }
        private void Button_Click13(object sender, RoutedEventArgs e)
        {
            if (img13.Source.ToString() == deseleccion1.Source.ToString())
            {
                img13.Source = new BitmapImage(new Uri(seleccionado));
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                img13.Source = new BitmapImage(new Uri(deseleccionado));
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }

        }
        private void Button_Click14(object sender, RoutedEventArgs e)
        {
            if (img14.Source.ToString() == deseleccion1.Source.ToString())
            {
                img14.Source = new BitmapImage(new Uri(seleccionado));
                contador += 1;
                selection.Text = contador + " Asientos seleccionados";
            }
            else
            {
                img14.Source = new BitmapImage(new Uri(deseleccionado));
                contador -= 1;
                selection.Text = contador + " Asientos seleccionados";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (contador == 0)
            {
                MessageBox.Show("Debe seleccionar por lo menos 1 asiento");
            }
            else
            {
                //Direccion de la siguiente página
            }
        }
    }
}



