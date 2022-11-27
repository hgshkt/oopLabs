namespace InternetShop.Models;

public class Book
{
    public string ImageUri { get; }

    public string Name { get; }

    public int Cost { get; }
    
    public Book(string imageName, string name, int cost)
    {
        ImageUri = "pack://application:,,,/assets/" + imageName + ".jpg";
        Name = name;
        Cost = cost;
    }
}