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

namespace Ejercicio4
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

        private string[] rutasImagenes = {
            "C:/Users/alumno/Desktop/Practica3_WPF/D1.webp",
            "C:/Users/alumno/Desktop/Practica3_WPF/D2.webp",
            "C:/Users/alumno/Desktop/Practica3_WPF/D3.jpg"
        };

        private int indiceImagenActual = 0;

        private void Cambiar(object sender, RoutedEventArgs e)
        {
            indiceImagenActual++;

            if (indiceImagenActual >= rutasImagenes.Length)
                indiceImagenActual = 0;

            BitmapImage nuevaImagen = new BitmapImage();
            nuevaImagen.BeginInit();
            nuevaImagen.UriSource = new Uri(System.IO.Path.GetFullPath(rutasImagenes[indiceImagenActual]), UriKind.Absolute);
            nuevaImagen.EndInit();

            Doramion.Source = nuevaImagen;

            MessageBox.Show($"Imagen cambiada a: {indiceImagenActual + 1}");
        }


    }
}