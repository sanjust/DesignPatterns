using System;
using IteratorPattern.Model;
using IteratorPattern.Service.Interface;

namespace IteratorPattern.Service
{
    public class BookShelf : IBookShelf
    {
        private readonly List<Book> _book = new();

        public BookShelf()
        {
        }

        public void Add(Book book) {
            _book.Add(book);
        }

        public IBookIterator CreateIterator()
        {
            return new BookIterator(_book);
        }
    }
}

