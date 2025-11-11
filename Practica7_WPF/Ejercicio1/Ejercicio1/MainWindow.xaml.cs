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

namespace Ejercicio1
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

        private void MensajeSimple(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mensaje simple");
        }

        private void MensajeTitulo(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mensaje con título", "Título");
        }

        private void MensajeBotones(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mensaje con botones", "Ventana de botones", MessageBoxButton.YesNoCancel);
        }

        private void MensajeConRespuesta(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resultado = MessageBox.Show("¿Es de día?","Pregunta",
                MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (resultado == MessageBoxResult.Yes)
            {
                MessageBox.Show("Has elegido 'Sí'");
            }
            else
            {
                MessageBox.Show("Has elegido 'No'");
            }
        }

        private void MensajeConIcono(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mensaje con icono", "Mensaje Icono", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MensajeEleccionDefecto(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resultado = MessageBox.Show("2 + 2 = 5?)",
                "Suma",
                MessageBoxButton.YesNoCancel, MessageBoxImage.Warning, MessageBoxResult.No );

            switch (resultado)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Has elegido 'Sí'");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Has elegido 'No', practica un poco más");
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("Operación cancelada");
                    break;
            }
        }
    }
}
