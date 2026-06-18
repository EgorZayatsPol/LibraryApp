using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp_V1._0.Models
{
    class Library
    {
        private static Library _instance;
        private List<Book> _books;
        private List<Reader> _readers;

        public List<Book> Books => _books;
        public List<Reader> Readers => _readers;

        private Library()
        {
            _books = new List<Book>();
            _readers = new List<Reader>();
        }

        public static Library Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Library();
                return _instance;
            }
        }
        public void AddBook(Book book)
        {
            _books.Add(book);
        }
        public void AddReader(Reader reader)
        {
            _readers.Add(reader);
        }
        public Book FindBook(string title)
        {
            foreach (var book in _books)
            {
                if (book.Title == title)
                    return book;
            }
            return null;
        }

    }
}
