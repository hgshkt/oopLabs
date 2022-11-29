using System.Windows;
using System.Windows.Controls;
using InternetShop.Models;

namespace InternetShop;

public partial class UserProfile : Window
{
    private readonly StackPanel _sp = new();
    
    public UserProfile()
    {
        InitializeComponent();
        UpdateUi();
        
        _sp.Orientation = Orientation.Horizontal;
        
        foreach (var book in CurrentUser.history)
        {
            var bookView = new BookView(book, false);
            _sp.Children.Add(bookView);
        }
        ScrollViewer.Content = _sp;
    }

    private void UpdateUi()
    {
        UserName.Text = CurrentUser.Name;
        UserCount.Text = CurrentUser.Count.ToString();
        TopUpBox.Text = "";
    }

    private void TopUpButtonClick(object sender, RoutedEventArgs e)
    {
        var amount = int.Parse(TopUpBox.Text);
        CurrentUser.Count += amount;
        
        UpdateUi();
    }

    private void BackButtonClick(object sender, RoutedEventArgs e)
    {
        var window = new ShopWindow();
        window.Show();
        Hide();
    }
}