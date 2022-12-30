using System.Windows;
using InternetShop.Models;

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
            User.currentUser.Name = TextBox.Text;
            var window = new ShopWindow();
            window.Show();
            Hide();
        }
    }
}