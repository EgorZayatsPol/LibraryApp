using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp_V1._0.Models
{
    class Book
    {
        private string _title;
        private string _author;
        private int _year;

        public string Title => _title;
        public string Author => _author;
        public int Year => _year;

        public bool IsBorrowed { get; private set; }

        public Book(string title, string author, int year)
        {
            _title = title;
            _author = author;
            _year = year;
            IsBorrowed = false;
        }
        public Book(Book other)
        {
            _title = other._title;
            _author = other._author;
            _year = other._year;
            IsBorrowed = false;
        }

        public void Borrow()
        {
            if (IsBorrowed)
                throw new InvalidOperationException("The book is borrowed");
            IsBorrowed = true;
        }

        public void Return()
        {
            if (!IsBorrowed)
                throw new InvalidOperationException("The book is not borrowed");
            IsBorrowed = false;
        }

        public override string ToString() => $"{Title} - {Author} ({Year})";


    }
}
