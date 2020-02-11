using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
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
        Compra compra;
        int idpeli, idfuncion, idsala, idasiento;
        public MainWindow(int idp,int idf,int ids)
        {
            InitializeComponent();
            this.DataContext = new ViewModel();
            idpeli = idp;
            idfuncion = idf;
            idsala = ids;
        }

        private void getAsiento()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-8CSIPAS\TEW_SQLEXPRESS;Initial Catalog=cine;Integrated Security=True");
            sqlcon.Open();
            String query = "select ID_asiento from Asiento where FK_ID_sala = 4";
            SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
            SqlDataReader registro = sqlcmd.ExecuteReader();
            idasiento = 4;
            sqlcon.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            getAsiento();
            compra = new Compra(idpeli,idfuncion,idsala,idasiento);
            compra.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PeliculasWindows peli = new PeliculasWindows();
            peli.Show();
            this.Close();
        }
    }

    public class ViewModel : INotifyPropertyChanged
    {
        private bool _isPlaying = false;
        private RelayCommand _playCommand;

        public ViewModel()
        {
            isPlaying = false;
        }

        public bool isPlaying
        {
            get { return _isPlaying; }
            set
            {
                _isPlaying = value;
                OnPropertyChanged("isPlaying");
            }
        }

        public ICommand PlayCommand
        {
            get
            {
                return _playCommand ?? new RelayCommand((x) =>
                {
                    var buttonType = x.ToString();

                    if (null != buttonType)
                    {
                        if (buttonType.Contains("asientoSeleccionado"))
                        {
                            isPlaying = false;
                        }
                        else if (buttonType.Contains("asientoDeseleccionado"))
                        {
                            isPlaying = true;
                        }
                    }
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class RelayCommand : ICommand
    {
        private readonly Predicate<object> _canExecute;
        private readonly Action<object> _execute;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action<object> execute) : this(execute, null) { }

        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {

            if (_canExecute == null)
            {
                return true;
            }

            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }

    }

}



