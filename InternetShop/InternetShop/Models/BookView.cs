using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace InternetShop.Models;

public class BookView
{
    private Image image;
    private Label name;
    private Label cost;

    public BookView(Image image, Label name, Label cost)
    {
        this.image = image;
        this.name = name;
        this.cost = cost;
    }

    public void BindBook(Book book)
    {
        BitmapImage logo = new BitmapImage();
        logo.BeginInit();
        logo.UriSource = new Uri(book.ImageUri);
        logo.EndInit();
        
        image.Source = logo;

        name.Content = book.Name;
        cost.Content = book.Cost + " грн";
    }
}