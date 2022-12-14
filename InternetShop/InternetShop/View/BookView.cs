using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace InternetShop.Models;

public class BookView : StackPanel
{
    private readonly Image _image = new();
    private readonly Label _labelName = new();
    private readonly Label _labelCost = new();
    private readonly Label _labelNumber = new();
    private readonly Button _button = new();
    
    private Book _book;
    private Type _type;

    public BookView(Book book, Type type)
    {
        _book = book;
        _type = type;
        
        CreatingView();
        BindBook(book);
    }

    private void Click(object sender, EventArgs e)
    {
        User.CurrentUser?.BuyBook(_book);
        updateUI();
    }

    private void CreatingView()
    {
        
        Margin = new Thickness(10, 0, 10, 0);

        _image.Name = "image";
        _image.Width = 200;
        _image.Height = 300;
        Children.Add(_image);

        _labelName.Name = "labelName";
        _labelName.Width = 200;
        _labelName.Height = 40;
        Children.Add(_labelName);

        if (_type == Type.Shop)
        {
            _labelCost.Name = "labelCost";
            _labelCost.Width = 200;
            _labelCost.Height = 40;
            Children.Add(_labelCost);
        
            _labelNumber.Name = "labelNumber";
            _labelNumber.Width = 200;
            _labelNumber.Height = 40;
            Children.Add(_labelNumber);
            
            var labelInButton = new Label();
            labelInButton.Content = "Купити";
            _button.Content = labelInButton;

            _button.Padding = new Thickness(10, 5, 10, 5);
            _button.Margin = new Thickness(5, 10, 5, 10);

            _button.Click += Click;
            Children.Add(_button);
        }
    }

    private void updateUI()
    {
        if (_book.Number > 0)
        {
            _labelNumber.Content = "Залишилось: " + _book.Number;
        }
        else
        {
            _labelNumber.Content = "Товар закінчився";
        }
    }

    private void BindBook(Book book)
    {
        _book = book;
        
        var logo = new BitmapImage();
        logo.BeginInit();
        logo.UriSource = new Uri(book.ImageUri);
        logo.EndInit();

        _image.Source = logo;

        _labelName.Content = book.Name;
        _labelCost.Content = book.Cost + " грн";

        updateUI();
    }
    
    public enum Type
    {
        History, Shop
    }
}