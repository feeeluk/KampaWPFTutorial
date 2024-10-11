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

namespace Tutorial_04___Code_Behind
{
    public partial class MainWindow : Window
    {
        bool running = false;

        public MainWindow()
        {
            InitializeComponent();

            //tbHello.Text = "Hello";
        }

        private void btnToggleStatus_Click(object sender, RoutedEventArgs e)
        {
            if (running)
            {
                // If already running when the button is clicked..
                tbStatus.Text = "Stopped";
                btnToggleStatus.Content = "Start";
            }

            else
            {
                // If stopped when the button is clicked..
                tbStatus.Text = "Running";
                btnToggleStatus.Content = "Stop";
            }

            running = !running;
        }
    }
}
