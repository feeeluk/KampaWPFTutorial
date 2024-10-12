using System.Windows;

namespace Tutorial_09___Message_Box
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Could not open file.", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}