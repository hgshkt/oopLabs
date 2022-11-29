using System.Windows;

namespace InternetShop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            CurrentUser.Name = TextBox.Text;
            var window = new ShopWindow();
            window.Show();
            Hide();
        }
    }
}