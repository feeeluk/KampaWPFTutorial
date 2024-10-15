using System.Collections.ObjectModel;
using System.Windows;

namespace Tutorial_13___ListView_2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = this;
            _entries = new ObservableCollection<string>();
            InitializeComponent();
        }

        private ObservableCollection<string> _entries;
        public  ObservableCollection<string> Entries
        {
            get { return _entries; }
            set { _entries = value; }
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Entries.Add(tbEntry.Text);
            tbEntry.Clear();
            tbEntry.Focus();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string selectedItem = (string)lvEntries.SelectedItem;
            Entries.Remove(selectedItem);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Entries.Clear();
        }
    }
}