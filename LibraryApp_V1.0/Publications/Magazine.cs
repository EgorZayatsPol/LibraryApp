using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp_V1._0.Publications
{
    class Magazine : Publication
    {
        private int _issueNumber;
        private DateTime _dateTime;

        public int IssueNumber
        {
            get => _issueNumber;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Isuue number must be positive");
                _issueNumber = value;
            }
        }

        public DateTime PublishDate
        {
            get => _dateTime;
            set
            {
                if (value.Year < 1900)
                    throw new ArgumentException("Date must be bigest then 1900 year");
                if (value < DateTime.Now)
                    throw new ArgumentException("Date must be bigest then now");
                _dateTime = value;
            }
        }

        public Magazine(string title, int year, int issueNumber, DateTime dateTime) : base(title, year)
        {
            IssueNumber = issueNumber;
            PublishDate = dateTime;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Title} - {_issueNumber} ({PublishDate.ToString("MMMM")})");
        }
    }
}
