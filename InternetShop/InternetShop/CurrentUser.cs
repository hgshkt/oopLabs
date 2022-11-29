using System.Collections.Generic;
using InternetShop.Models;

namespace InternetShop;

public static class CurrentUser
{
    public static string Name { get; set; }

    public static int Count { get; set; } = 0;

    public static List<Book> history = new();

    public static void BuyBook(Book book)
    {
        if (Count < book.Cost) return;
        Count -= book.Cost;
        history.Add(book);
    }
}