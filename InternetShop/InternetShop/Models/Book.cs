using System.Runtime.Serialization;

namespace InternetShop.Models;

[DataContract]
public class Book
{
    [DataMember]
    public string ImageUri { get; }

    [DataMember]
    public string Name { get; }

    [DataMember]
    public int Cost { get; }
    
    public Book(string imageName, string name, int cost)
    {
        ImageUri = "pack://application:,,,/assets/" + imageName + ".jpg";
        Name = name;
        Cost = cost;
    }
}