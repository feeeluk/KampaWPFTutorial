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
            //MessageBox.Show("Could not open file.", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            MessageBoxResult result = MessageBox.Show("Oui or non?", "Question!", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                tbInfo.Text = result.ToString();
            }

            else
            {
                tbInfo.Text = result.ToString();
            }

        }
    }
}