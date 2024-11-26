using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    internal class Library
    {
        private string[] _books;
        private int _count = 0;

        public Library(int size)
        {
            _books = new string[size];
            _count = 0;
        }

        public int Count
        {
            get 
            { 
                return _count;
            }
            set 
            {
                if (value >= 0 && value <= _books.Length)
                {
                    _count = value;
                }
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < _books.Length)
                {
                    return _books[index];
                }
                return null;
            }
            set
            {
                if (index >= 0 && index < _books.Length)
                {
                    _books[index] = value;
                }
            }
        }

        public void Add(string book)
        {
            if (_count < _books.Length)
            {
                _books[_count] = book;
                _count++;
            }
        }

        public void Remove(string book)
        {
            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i] == book)
                {
                    for (int j = i; j < _books.Length - 1; j++)
                    {
                        _books[j] = _books[j + 1];
                    }
                    _count--;
                    break;
                }
            }
        }

        public bool Contains(string book)
        {
            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i] == book)
                {
                    return true;
                }
            }
            return false;
        }

        public static Library operator +(Library library, string book)
        {
            library.Add(book);
            return library;
        }

        public static Library operator -(Library library, string book)
        {
            library.Remove(book);
            return library;
        }
        
        public string Find(string book)
        {
            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i] == book)
                {
                    return _books[i];
                }
            }
            return null;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _books.Length; i++)
            {
                sb.Append(_books[i] + "\n");
            }
            return sb.ToString();
        }
    }
}
