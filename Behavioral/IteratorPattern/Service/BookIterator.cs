using System;
using IteratorPattern.Model;
using IteratorPattern.Service.Interface;

namespace IteratorPattern.Service
{
    public class BookIterator : IBookIterator
    {
        private readonly List<Book> _book;
        private int _position = 0;

        public BookIterator(List<Book> books)
        {
            _book = books;
        }

        public Book Current()
        {
            return _book[_position];
        }

        public bool HasNext()
        {
            return _position < _book.Count();
        }

        public void Next()
        {
            _position++;
        }
    }
}

