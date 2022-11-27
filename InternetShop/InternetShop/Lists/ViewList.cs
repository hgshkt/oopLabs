using System.Collections.Generic;
using InternetShop.Models;

namespace InternetShop.Lists;

public class ViewList
{
    private readonly List<BookView> views = new();

    public ViewList(ShopWindow window) {
        views.Add(new BookView(window.Image0, window.ProductName0, window.ProductCost0));
        views.Add(new BookView(window.Image1, window.ProductName1, window.ProductCost1));
        views.Add(new BookView(window.Image2, window.ProductName2, window.ProductCost2));
        views.Add(new BookView(window.Image3, window.ProductName3, window.ProductCost3));
        views.Add(new BookView(window.Image4, window.ProductName4, window.ProductCost4));
        views.Add(new BookView(window.Image5, window.ProductName5, window.ProductCost5));
        views.Add(new BookView(window.Image6, window.ProductName6, window.ProductCost6));
        views.Add(new BookView(window.Image7, window.ProductName7, window.ProductCost7));
        views.Add(new BookView(window.Image8, window.ProductName8, window.ProductCost8));
        views.Add(new BookView(window.Image9, window.ProductName9, window.ProductCost9));

        BindAllBooks();
    }

    private void BindAllBooks()
    {
        for (int i = 0; i < views.Count; i++)
        {
            Book book = Storage.getBook(i);
            views[i].BindBook(book);
        }
    }
}