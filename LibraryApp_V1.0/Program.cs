using System;
using LibraryApp_V1._0.Models;


namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Library: {Config.LibraryName}, Vercion: {Config.Version}");
            Library library = Library.Instance;


            Book b1 = new Book("Dune", "Frank Herbert", 1965);
            Book b2 = new Book("Koki", "Luk Besson", 2004);
            Book b3 = new Book("Gogrosso", "Egor Zayats", 1904);

            library.AddBook(b1);
            library.AddBook(b2);
            library.AddBook(b3);

            Reader r1 = new Reader("Alice");
            Reader r2 = new Reader("Fanfurik");

            library.AddReader(r1);
            library.AddReader(r2);


            Book found = library.FindBook("1984");
            Console.WriteLine(found != null ? "Book found: " + found : "Book not found");

            r1.TakeBook(b2);
            Console.WriteLine($"{r1.NameOfReader} took the book: {b2.Title}");

            r1.ReturnBook(b2);
            Console.WriteLine($"{r1.NameOfReader} returned the book: {b2.Title}");


        }
    }
}
