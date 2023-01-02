using System;
using System.IO;
using System.Runtime.Serialization.Json;
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
            
            DataContractJsonSerializer serializer = new(typeof(User));

            string path = @"users/" + TextBox.Text + ".json";
            if (File.Exists(path))
            {
                FileStream stream = new FileStream(path, FileMode.Open);
                User.CurrentUser = (User)serializer.ReadObject(stream)!;   
                stream.Close();
            }
            else
            {
                User.CurrentUser = new(TextBox.Text);
            }

            var window = new ShopWindow();
            window.Show();
            Hide();
        }
        
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }
    }
}