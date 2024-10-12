using Microsoft.Win32;
using System.Windows;

namespace Tutorial_10___Open_File_Dialog__file_picker_
{
   public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "C# Source Files | *.cs";
            // fileDialog.DefaultDirectory
            fileDialog.Title = "Please select source file(s)";
            fileDialog.Multiselect = true;

            bool? success = fileDialog.ShowDialog();

            if(success == true)
            {
                string[] paths = fileDialog.FileNames;
                string[] fileNames = fileDialog.SafeFileNames;
                tbInfo.Text = paths + " | " + fileNames;
            }

            else
            {
                // Didn't select anything
                tbInfo.Text = "no selection";
            }
        }
    }
}