using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using InternetShop.Models;

namespace InternetShop.Lists;

[DataContract]
public class Storage
{
    private static Storage _instance;
    private const string Path = @"storage/storage.json";
    
    [DataMember] public List<Book> Books = new();

    public static Storage Instance
    {
        get
        {
            if (_instance == null)
            {
                DataContractJsonSerializer serializer = new(typeof(Storage));
                
                if (File.Exists(Path))
                {
                    FileStream stream = new FileStream(Path, FileMode.Open);
                    _instance = (Storage)serializer.ReadObject(stream)!;
                    stream.Close();
                }
            }

            return _instance;
        }
    }

    public void save()
    {
        DataContractJsonSerializer serializer = new(typeof(Storage));
        using FileStream stream = new(Path, FileMode.OpenOrCreate);
        serializer.WriteObject(stream, this);
        stream.Close();
    }
}