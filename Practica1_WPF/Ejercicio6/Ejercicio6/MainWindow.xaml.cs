using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ejercicio6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Boton(object sender, RoutedEventArgs e) {

            string texto = Recopilador.Text; //Recopilo el texto

            if (texto == "Hola")
            {
                MessageBox.Show("Hola máquina");
            }

            else
            {
                Application.Current.Shutdown();
            }

        }
    }
}