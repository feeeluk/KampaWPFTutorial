using System.Windows;

namespace Tutorial_19___Opening_Windows.View
{
    public partial class ModalWindow : Window
    {
        public ModalWindow(Window parentWindow)
        {
            Owner = parentWindow;
            InitializeComponent();
        }

        public string Input { get; set; }
        public bool Success { get; set; }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            Success = true;
            Input = tbInput.Text; 
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void tbInput_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbInput.Text))
            {
                btnOK.IsEnabled = true;
            }
            else
            {
                btnOK.IsEnabled = false;
            }
        }
    }
}
