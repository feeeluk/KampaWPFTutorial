using System.Windows;
using Tutorial_19___Opening_Windows.View;


namespace Tutorial_19___Opening_Windows
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNormalWindow_Click(object sender, RoutedEventArgs e)
        {
            NormalWindow normalWindow = new NormalWindow();
            normalWindow.Show();
        }

        private void btnModalWindow_Click(object sender, RoutedEventArgs e)
        {
            ModalWindow modalWindow = new ModalWindow(this);
            Opacity = 0.4;
            modalWindow.ShowDialog();
            Opacity = 1;
            if(modalWindow.Success)
            {
                tbInput.Text = modalWindow.Input;
            }
        }
    }
}