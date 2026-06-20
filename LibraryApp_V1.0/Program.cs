using System;
using LibraryApp_V1._0.Models;
using LibraryApp_V1._0.Publications;
using Book = LibraryApp_V1._0.Publications.Book;


namespace LibraryApp_V1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("\n=== Library Menu ===");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Add AudioBook");
                Console.WriteLine("3. Add Magazine");
                Console.WriteLine("4. Show All Publications");
                Console.WriteLine("5. Find by Title");
                Console.WriteLine("0. Exit");
                Console.Write("Choose option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBook(library);
                        break;

                    case "2":
                        AddAudioBook(library);
                        break;

                    case "3":
                        AddMagazine(library);
                        break;

                    case "4":
                        library.PrintAll();
                        break;

                    case "5":
                        FindPublication(library);
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        static void AddBook(Library library)
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            Book book = new Book(title, year, author);
            library.AddPublication(book);

            Console.WriteLine("Book added!");
        }

        static void AddAudioBook(Library library)
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Narrator: ");
            string narrator = Console.ReadLine();

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Duration (minutes): ");
            int duration = int.Parse(Console.ReadLine());

            AudioBook audio = new AudioBook(title, year, narrator, duration);
            library.AddPublication(audio);

            Console.WriteLine("AudioBook added!");
        }

        static void AddMagazine(Library library)
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Issue number: ");
            int issue = int.Parse(Console.ReadLine());

            Console.Write("Release date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Magazine mag = new Magazine(title, year, issue, date);
            library.AddPublication(mag);

            Console.WriteLine("Magazine added!");
        }

        static void FindPublication(Library library)
        {
            Console.Write("Enter title: ");
            string title = Console.ReadLine();

            var result = library.FindByTitle(title);

            if (result == null)
                Console.WriteLine("Not found.");
            else
                result.PrintInfo();
        }
    }
}
