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

        private void Label_AccessKeyPressed(object sender, AccessKeyPressedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (txtNombre.Text.Length > 0 && txtEmail.Text.Length > 0 && txtComentario.Text.Length > 0)
            {
                
                MessageBox.Show("El usuario " + txtNombre.Text + " con email " + txtEmail.Text +" dice "+txtComentario.Text, "Información", MessageBoxButton.OK, MessageBoxImage.Warning);


            }

        }
    }
}