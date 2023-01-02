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

    public static Storage Instance
    {
        get
        {
            if (_instance == null)
            {
                DataContractJsonSerializer serializer = new(typeof(Storage));

                string path = @"storage/storage.json";
                if (File.Exists(path))
                {
                    FileStream stream = new FileStream(path, FileMode.Open);
                    _instance = (Storage)serializer.ReadObject(stream)!;
                    stream.Close();
                }
            }

            return _instance;
        }
    }

    [DataMember] public List<Book> Books = new();

    // private Storage()
    // {
    //     DataContractJsonSerializer serializer = new(typeof(Storage));
    //
    //     string path = @"storage/storage.json";
    //     if (File.Exists(path))
    //     {
    //         FileStream stream = new FileStream(path, FileMode.Open);
    //         this = (Storage)serializer.ReadObject(stream)!;
    //         stream.Close();
    //     }
    //
    //     // Books.Add(new Book("lovecraft1", "Збірник Лавкрафт том 1", 360));
    //     // Books.Add(new Book("lovecraft3", "Збірник Лавкрафт том 3", 360));
    //     // Books.Add(new Book("berserk12", "Манга \"Берсерк\" том 12", 280));
    //     // Books.Add(new Book("berserk37", "Манга \"Берсерк\" том 37", 285));
    //     // Books.Add(new Book("berserk40", "Манга \"Берсерк\" том 40", 310));
    //     // Books.Add(new Book("death_note1", "Манга \"Зошит Смерті\" том 1", 200));
    //     // Books.Add(new Book("death_note2", "Манга \"Зошит Смерті\" том 2", 220));
    //     // Books.Add(new Book("graveyard", "Книга Стівен Кінг \"Кладовище Домашніх Тварин\"", 250));
    //     // Books.Add(new Book("it", "Книга Стівен Кінг \"Воно\"", 380));
    //     // Books.Add(new Book("shine", "Книга Стівен Кінг \"Сяйво\"", 200));
    //     // DataContractJsonSerializer serializer = new(typeof(Storage));
    //     // using FileStream stream = new("storage/storage.json", FileMode.OpenOrCreate);
    //     // serializer.WriteObject(stream, this);
    //     // stream.Close();
    // }
}