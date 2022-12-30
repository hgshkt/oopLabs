using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace InternetShop.Models;

[DataContract]
public class User
{
    public static User currentUser = new();
    
    private string _name = "";

    [DataMember]
    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            save();
        }
    }

    private int _count = 0;

    [DataMember]
    public int Count
    {
        get => _count;
        set
        {
            _count = value;
            save();
        }
    }

    private List<Book> _history = new();

    [DataMember]
    public List<Book> History
    {
        get => _history;
        set
        {
            _history = value;
        }
    }

    public void BuyBook(Book book)
    {
        if (Count < book.Cost) return;
        Count -= book.Cost;
        History.Add(book);
    }

    private void save()
    {
        DataContractJsonSerializer serializer = new(typeof(User));
        using (FileStream stream = new(Name + ".json", FileMode.OpenOrCreate))
        {
            serializer.WriteObject(stream, this);
        }
    }
}