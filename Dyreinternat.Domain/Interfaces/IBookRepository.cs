using System.Collections.Generic;
using Dyreinternat.Domain.Models;

namespace Dyreinternat.Domain.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        void Add(Book book);
        Book GetById(int id);
        void Remove(int id);
    }
}


