using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace InternetShop.Models;

[DataContract]
public class User
{
    public static User? currentUser;

    [DataMember] public string Name { get; set; }

    private int _count;

    [DataMember] public int Count { get; set; }

    [DataMember] public List<Book> History { get; set; }

    public User(string name)
    {
        Name = name;
        History = new();
        _count = 0;
        save();
    }

    public void BuyBook(Book book)
    {
        if (Count < book.Cost) return;
        Count -= book.Cost;
        History.Add(book);
        save();
    }

    public void accrue(int count)
    {
        Count += count;
        save();
    }

    private void save()
    {
        DataContractJsonSerializer serializer = new(typeof(User));
        using (FileStream stream = new(Name + ".json", FileMode.OpenOrCreate))
        {
            serializer.WriteObject(stream, this);
            stream.Close();
        }
    }
}