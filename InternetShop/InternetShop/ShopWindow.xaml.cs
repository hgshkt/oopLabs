﻿using System.Windows;
using System.Windows.Controls;
using InternetShop.Lists;

namespace InternetShop;

public partial class ShopWindow : Window
{
    private readonly StackPanel _sp = new();

    public ShopWindow()
    {
        InitializeComponent();
        var list = new BookViewList(true);

        _sp.Orientation = Orientation.Horizontal;

        foreach (var bookView in list.views)
        {
            _sp.Children.Add(bookView);
        }

        ScrollViewer.Content = _sp;
    }

    private void ToUserProfile(object sender, RoutedEventArgs e)
    {
        UserProfile window = new UserProfile();
        window.Show();
        Hide();
    }
}