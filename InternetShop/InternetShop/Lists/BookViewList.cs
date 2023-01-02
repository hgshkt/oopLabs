using System.Collections.Generic;
using InternetShop.Models;

namespace InternetShop.Lists;

public class BookViewList
{
    public readonly List<BookView> Views = new();

    public BookViewList(BookView.Type type)
    {
        foreach (var book in Storage.Instance.Books)
        {
            var bookView = new BookView(book, type);
            Views.Add(bookView);
        }
    }
}