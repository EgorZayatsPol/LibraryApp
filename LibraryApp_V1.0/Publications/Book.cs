using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp_V1._0.Publications
{
    class Book : Publication
    {
        private string _author;
        public string Author => _author;
        
        
        public Book(string title, int year, string author) : base(title, year)
        {
            _author = author;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Title} - {_author} ({Year})");
        }


    }
}
