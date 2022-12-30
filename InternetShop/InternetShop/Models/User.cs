using System.Collections.Generic;

namespace InternetShop.Models;

public class User
{
    public static User currentUser = new();
    
    public string Name { get; set; }
    private int _count = 0;

    public int Count { get; set; }

    public List<Book> history = new();

    public void BuyBook(Book book)
    {
        if (Count < book.Cost) return;
        Count -= book.Cost;
        history.Add(book);
    }
}