using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Imaging;

namespace InternetShop.Models;

public class BookView : StackPanel
{
    public readonly Image Image = new();
    public readonly Label LabelName = new();
    public readonly Label LabelCost = new();
    public readonly Button Button = new();
    
    private Book _book;
    private bool _purchased;

    public BookView(Book book, bool purchased)
    {
        _purchased = purchased;
        _book = book;
        
        CreatingView();
        BindBook(book);
    }
    
    void click(object sender, EventArgs e)
    {
        CurrentUser.BuyBook(_book);
    }

    private void CreatingView()
    {
        
        Margin = new Thickness(10, 0, 10, 0);

        Image.Name = "image";
        Image.Width = 200;
        Image.Height = 300;
        Children.Add(Image);

        LabelName.Name = "labelName";
        LabelName.Width = 200;
        LabelName.Height = 40;
        Children.Add(LabelName);

        LabelCost.Name = "labelCost";
        LabelCost.Width = 200;
        LabelCost.Height = 40;
        Children.Add(LabelCost);

        if (!_purchased) return;
        var labelInButton = new Label();
        labelInButton.Content = "Купити";
        Button.Content = labelInButton;

        Button.Padding = new Thickness(10, 5, 10, 5);
        Button.Margin = new Thickness(5, 10, 5, 10);

        Button.Click += click;
        Children.Add(Button);
    }
    
    private void BindBook(Book book)
    {
        _book = book;
        
        var logo = new BitmapImage();
        logo.BeginInit();
        logo.UriSource = new Uri(book.ImageUri);
        logo.EndInit();

        Image.Source = logo;

        LabelName.Content = book.Name;
        LabelCost.Content = book.Cost + " грн";
    }
}