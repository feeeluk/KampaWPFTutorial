using Microsoft.Win32;
using System.Windows;

namespace Tutorial_11___Folder_Browser_Dialog
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            var folderDialog = new OpenFolderDialog();
            folderDialog.Title = "Select Folder";
            folderDialog.InitialDirectory = "C:\\Users\\phili\\source\\repos\\KampaWPFTutorial";

            folderDialog.ShowDialog();
            if (folderDialog.ShowDialog() == true)
            {
                var folderName = folderDialog.FolderName;
                MessageBox.Show($"You picked ${folderName}!");
            }

        }
    }
}