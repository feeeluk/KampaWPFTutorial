using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Tutorial_08___Data_Binding
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

        private string _boundText;

        public event PropertyChangedEventHandler? PropertyChanged;

        public  string BoundText
        {
            get { return _boundText; }
            set { 
                    _boundText = value;
                    // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundText"));
                    OnPropertyChanged();
                }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "set from code";
        }

        private void OnPropertyChanged( [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}