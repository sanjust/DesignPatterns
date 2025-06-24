using System;
using IteratorPattern.Model;

namespace IteratorPattern.Service.Interface
{
    public interface IBookShelf
    {
        public IBookIterator CreateIterator();
    }
}

