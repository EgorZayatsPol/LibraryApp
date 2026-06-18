using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp_V1._0.Publications
{
    class Publication
    {
        private string _title;
        private int _year;


        public string Title
        {
            get => _title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new AggregateException("Title cannot be empty!");
                _title = value;
            }
        }
        public int Year
        {
            get => _year;
            set
            {
                if (value < 0)
                    throw new AggregateException("Year cannot be negative");
                _year = value;
            }
        }
        public Publication(string title, int year)
        {
            _title = title;
            _year = year;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Print info: ");
        }
    }
}
