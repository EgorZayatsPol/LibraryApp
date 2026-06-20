using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp_V1._0.Publications
{
    class AudioBook : Publication
    {
        private int _duration;
        private string _narrator;

        public int Duration
        {
            get => _duration;
                set
            {
                if (value < 0)
                    throw new ArgumentException("Duration must be positive");
                _duration = value;
            }
        }
            
        public string Narrator => _narrator;

        public AudioBook(string title, int year, string narrator, int duration) : base(title, year)
        {
            _duration = duration;
            _narrator = narrator;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Title} - {_narrator} ({Year}), {_duration} min");
        }
    }
}
