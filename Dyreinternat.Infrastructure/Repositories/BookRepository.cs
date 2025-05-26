using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Dyreinternat.Domain.Models;
using Dyreinternat.Domain.Interfaces;

namespace Dyreinternat.Infrastructure.Repositories
{

public class BookRepository : IBookRepository
{
    private List<Book> _books;

    public BookRepository()
    {
        _books = new List<Book>();
    }

    public void Add(Book book)
    {
        _books.Add(book);
    }

    public List<Book> GetAll()
    {
        return _books;
    }

    public Book GetById(int id)
    {
        foreach (Book book in _books)
        {
            if (book.Id == id)
            {
                return book;
            }
        }

        return null;
    }

    public void Remove(int id)
    {
        Book book = GetById(id);
        if (book != null)
        {
            _books.Remove(book);
        }
    }
}
}


