using System.Collections;
using System.Windows;

namespace Tutorial_12___ListView
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lvEntries.Items.Add("A");
            lvEntries.Items.Add("B");
            lvEntries.Items.Add("C");
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Add(tbEntry.Text);
            tbEntry.Clear();
            tbEntry.Focus();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int index = lvEntries.SelectedIndex;
            // lvEntries.Items.RemoveAt(index);

            //object item = lvEntries.SelectedItem;

            var items = lvEntries.SelectedItems;
            var result = MessageBox.Show($"Are you sure you want to to delete {items.Count} items?", "Delete?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                var itemsList = new ArrayList(items);
                foreach (var item in itemsList)
                {
                    lvEntries.Items.Remove(item);
                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }
    }
}