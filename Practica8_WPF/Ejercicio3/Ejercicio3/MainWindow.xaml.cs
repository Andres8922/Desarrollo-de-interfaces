using System.Windows;
using System.Windows.Input;

namespace Ejercicio3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Nuevo
        private void CommandNew_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void New_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtbox.Clear();
        }

        // Guardar
        private void CommandSave_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (txtbox != null && !string.IsNullOrEmpty(txtbox.Text));
        }

        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            
            Microsoft.Win32.SaveFileDialog saveDialog = new Microsoft.Win32.SaveFileDialog();

            if (saveDialog.ShowDialog() == true){
                
                System.IO.File.WriteAllText(saveDialog.FileName, txtbox.Text);
            
            }
        }

        // Cortar
        private void CommandCut_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (txtbox != null && txtbox.SelectionLength > 0);
        }

        private void Cut_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtbox.Cut();
        }

        // Copiar
        private void CommandCopy_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (txtbox != null && txtbox.SelectionLength > 0);
        }

        private void Copy_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtbox.Copy();
        }

        // Pegar
        private void CommandPaste_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (txtbox != null && Clipboard.ContainsText());
        }

        private void Paste_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtbox.Paste();
        }
    }
}