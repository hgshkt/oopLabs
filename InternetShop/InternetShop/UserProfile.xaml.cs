using System;
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
        
        foreach (var book in User.CurrentUser!.History)
        {
            var bookView = new BookView(book, BookView.Type.History);
            _sp.Children.Add(bookView);
        }
        ScrollViewer.Content = _sp;
    }

    private void UpdateUi()
    {
        UserName.Text = User.CurrentUser!.Name;
        UserCount.Text = User.CurrentUser.Count.ToString();
        TopUpBox.Text = "";
    }

    private void TopUpButtonClick(object sender, RoutedEventArgs e)
    {
        var amount = int.Parse(TopUpBox.Text);
        User.CurrentUser?.Accrue(amount);
        
        UpdateUi();
    }

    private void BackButtonClick(object sender, RoutedEventArgs e)
    {
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