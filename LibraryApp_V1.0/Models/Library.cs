using System;
using System.Collections.Generic;
using System.Linq;
using LibraryApp_V1._0.Publications;


namespace LibraryApp_V1._0.Models
{
    class Library
    {
        private List<Publication> _publications = new List<Publication>();

        public void AddPublication(Publication publication)
        {
            if (publication == null)
                throw new ArgumentNullException(nameof(publication));

            _publications.Add(publication);
        }

        public void PrintAll()
        {
            if (_publications.Count == 0)
            {
                Console.WriteLine("Library is empty.");
                return;
            }

            foreach (var p in _publications)
                p.PrintInfo();
        }

        public Publication FindByTitle(string title)
        {
            return _publications
                .FirstOrDefault(p => p.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
    }
}
