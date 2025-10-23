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

namespace Ejercicio2
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

        int contador;

        public void Comprobar(object sender, RoutedEventArgs e)
        {

            contador++;

            if (contador > 2)
            {
                MessageBox.Show("Máximo de intentos alcanzado, ya no le quedan más");
            }

            else if (correcto.IsChecked == true)
            {
                MessageBox.Show("Respuesta correcta, número de intentos: " + contador);

            }

            else if (correcto.IsChecked == false)
            {

                MessageBox.Show("Respuesta incorrecta");


            }


        }

    }
}