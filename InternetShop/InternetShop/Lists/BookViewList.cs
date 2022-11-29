using System.Collections.Generic;
using System.Windows.Controls;
using InternetShop.Models;

namespace InternetShop.Lists;

public class BookViewList
{
    public readonly List<BookView> views = new();

    public BookViewList(bool purchased) {
        foreach (var book in Storage.Books)
        {
            var bookView = new BookView(book, purchased);
            views.Add(bookView);
        }
    }
}