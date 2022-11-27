using System.Collections.Generic;
using InternetShop.Models;

namespace InternetShop.Lists;

public static class Storage
{
    private static readonly List<Book> Books = new();

    static Storage() {
        Books.Add(new Book("lovecraft1", "Збірник Лавкрафт том 1", 360));
        Books.Add(new Book("lovecraft3", "Збірник Лавкрафт том 3", 360));
        Books.Add(new Book("berserk12", "Манга \"Берсерк\" том 12", 280));
        Books.Add(new Book("berserk37", "Манга \"Берсерк\" том 37", 285));
        Books.Add(new Book("berserk40", "Манга \"Берсерк\" том 40", 310));
        Books.Add(new Book("death_note1", "Манга \"Зошит Смерті\" том 1", 200));
        Books.Add(new Book("death_note2", "Манга \"Зошит Смерті\" том 2", 220));
        Books.Add(new Book("graveyard", "Книга Стівен Кінг \"Кладовище Домашніх Тварин\"", 250));
        Books.Add(new Book("it", "Книга Стівен Кінг \"Воно\"", 380));
        Books.Add(new Book("shine", "Книга Стівен Кінг \"Сяйво\"", 200));
    }

    public static Book getBook(int number)
    {
        return Books[number];
    }
}