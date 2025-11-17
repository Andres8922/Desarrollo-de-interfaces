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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El contenido es " + txtbox.Text, "Mostrar", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        //Cortar
        private void CommandCut_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (txtbox.Text.Length > 0)
            {
                e.CanExecute = true;   
            }
        }

        private void CommandCut_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtbox.Cut();
        }

        //Copiar
        private void CommandCopy_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (txtbox.Text.Length > 0)
            {
                e.CanExecute = true;
            }
        }

        private void Copy_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtbox.Copy();
        }

        //Pegar
        private void CommandPaste_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (txtbox.Text.Length > 0)
            {
                e.CanExecute = true;
            }
        }

        private void Paste_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtbox.Paste();
        }

    }
}