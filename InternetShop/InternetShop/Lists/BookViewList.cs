using System.Collections.Generic;
using InternetShop.Models;

namespace InternetShop.Lists;

public class BookViewList
{
    public readonly List<BookView> Views = new();

    public BookViewList(bool purchased) {
        foreach (var book in Storage.Books)
        {
            var bookView = new BookView(book, purchased);
            Views.Add(bookView);
        }
    }
}