using System.Windows;
using System.Windows.Controls;

namespace Tutorial_07___Custom_Controls_2.View.UserControls
{
    public partial class ClearableTextBox : UserControl
    {
        private String _placeholder;

        public String Placeholder
        {
            get { return _placeholder; }
            set { 
                    _placeholder = value;
                    // Do not use this!!
                    // Use OnPropertyChanged()
                    tbPlaceholder.Text = _placeholder;
                }
        }


        public ClearableTextBox()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(txtInput.Text))
            {
                tbPlaceholder.Visibility = Visibility.Visible;
            }
            else
            {
                tbPlaceholder.Visibility = Visibility.Hidden;
            }
        }
    }
}
