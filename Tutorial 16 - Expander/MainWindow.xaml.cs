using System.Windows;

namespace Tutorial_16___Expander
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //bool _isExpanded = false;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            expanderDetails.IsExpanded = !expanderDetails.IsExpanded;
            //if (_isExpanded)
            //{
            //    expanderDetails.IsExpanded = expanderDetails.IsExpanded = false;
            //    btnDetails.Content = "Expand";
            //}
            //else
            //{
            //    expanderDetails.IsExpanded = expanderDetails.IsExpanded = true;
            //    btnDetails.Content = "Collapse";

            //}

            //_isExpanded = !_isExpanded;
        }
    }
}