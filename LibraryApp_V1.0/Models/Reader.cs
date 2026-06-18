using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp_V1._0.Models
{
    class Reader
    {
        private string _nameOfReader;
        private List<Book> _books;

        public string NameOfReader => _nameOfReader;
        public List<Book> Books => _books;


        public Reader(string nameOfReader)
        {
            _nameOfReader = nameOfReader;
            _books = new List<Book>();
        }

        public void TakeBook(Book book)
        {
            _books.Add(book);
        }

        public void ReturnBook(Book book)
        {
            _books.Remove(book);
        }
    }
}
