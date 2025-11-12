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

namespace Principiante
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

        private void saludar(object sender, RoutedEventArgs e)
        {

            string txt = txtNombre.Text;

            if (txt.Length > 0)
            {
                Window1 ventana = new Window1();

                ventana.txtsaludo.Text = "Hola " + txt + ", esta es la segunda ventana";

                ventana.ShowDialog();
            }

            else
            {
                MessageBox.Show("Por favor, escribe tu nombre antes de continuar");
            }

        }
    }
}