using System.Windows;
using InternetShop.Lists;

namespace InternetShop;

public partial class ShopWindow : Window
{
    
    
    public ShopWindow()
    {
        InitializeComponent();
        ViewList list = new ViewList(this);
    }

    private void ToUserProfile(object sender, RoutedEventArgs e)
    {
        
    }
}