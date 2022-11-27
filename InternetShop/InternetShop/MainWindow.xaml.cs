using System.Windows;

namespace InternetShop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void login(object sender, RoutedEventArgs e)
        {
            CurrentUser.Name = TextBox.Text;
        }
    }
}