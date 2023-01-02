using System.Runtime.Serialization;

namespace InternetShop.Models;

[DataContract]
public class Book
{
    [DataMember]
    public string ImageUri { set; get; }

    [DataMember]
    public string Name { set; get; }

    [DataMember]
    public int Cost { set; get; }

    [DataMember]
    public int Number { set; get; }

    public Book(string imageName, string name, int cost, int number)
    {
        ImageUri = "pack://application:,,,/assets/" + imageName + ".jpg";
        Name = name;
        Cost = cost;
        Number = number;
    }
}