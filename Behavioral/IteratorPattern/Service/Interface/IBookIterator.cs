using System;
using IteratorPattern.Model;

namespace IteratorPattern.Service.Interface
{
    public interface IBookIterator
    {
        public void Next();
        public bool HasNext();
        public Book Current();
    }
}

