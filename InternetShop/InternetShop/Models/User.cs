using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using InternetShop.Lists;

namespace InternetShop.Models;

[DataContract]
public class User
{
    public static User? CurrentUser;

    [DataMember] public string Name { get; set; }
    [DataMember] public int Count { get; set; }
    [DataMember] public List<Book> History { get; set; }

    public User(string name)
    {
        Name = name;
        History = new List<Book>();
        Count = 0;
        Save();
    }

    public void BuyBook(Book book)
    {
        if (Count < book.Cost) return;
        Count -= book.Cost;
        book.Number--;
        History.Add(book);
        Save();
        Storage.Instance.save();
    }

    public void Accrue(int count)
    {
        Count += count;
        Save();
    }

    private void Save()
    {
        DataContractJsonSerializer serializer = new(typeof(User));
        using FileStream stream = new("users/" + Name + ".json", FileMode.OpenOrCreate);
        serializer.WriteObject(stream, this);
        stream.Close();
    }
}