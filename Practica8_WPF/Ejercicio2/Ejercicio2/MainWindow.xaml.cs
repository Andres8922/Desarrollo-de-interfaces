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

        private void Usuario_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Se ha elegido la opción de Usuario");
        }

        private void Saldo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Se ha elegido la opción de Saldo");
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Se ha elegido la opción de Salir");
        }


        private void Sumar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Se ha elegido la opción de Sumar");
        }

        private void Restar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Se ha elegido la opción de Restar");
        }
    }
}