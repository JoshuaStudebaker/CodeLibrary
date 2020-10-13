using System;
using System.Collections.Generic;
using CodeLibrary.Models;

namespace CodeLibrary.Services
{
  class LibraryService
  {

    private List<Book> Books { get; set; }

    public string GetBooks(bool available)
    {
      string list = "";
      for (int i = 0; i < Books.Count; i++)
      {
        var book = Books[i];
        if (book.IsAvailable == available)
        {
          list += $"{i + 1}. {book.Title} - by {book.Author}\n";
        }
      }
      return list;
    }
  }
  private void Checkout()
  {
    Console.WriteLine(_service.GetBooks(true));
  }

  private void Return()
  {
    Console.WriteLine(_service.GetBooks(false));
  }

}