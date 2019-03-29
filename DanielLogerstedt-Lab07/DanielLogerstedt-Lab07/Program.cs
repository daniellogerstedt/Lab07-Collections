using System;
using System.Collections.Generic;
using LendingLibrary.Classes;
using LendingLibrary.Enums;

namespace LendingLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Borrow();
        }


        public static void Borrow()
        {
            Library<Book> library = new Library<Book>();

            library.Add(new Book(new Author { Name = "Dr. Seuss" }, "Red Fish, Blue Fish, One Fish, Two Fish", Genre.Horror));
            library.Add(new Book(new Author { Name = "George Orwell" }, "1984", Genre.Science));
            library.Add(new Book(new Author { Name = "Ryan W. Aslesen" }, "Existential", Genre.Science));
            library.Add(new Book(new Author { Name = "Tolkien" }, "Fellowship of the Ring", Genre.Fantasy));
            library.Add(new Book(new Author { Name = "Tolkien" }, "The Two Towers", Genre.Fantasy));
            library.Add(new Book(new Author { Name = "Tolkien" }, "Return of the King", Genre.Fantasy));
            library.Add(new Book(new Author { Name = "George Orwell" }, "Animal Farm", Genre.Fantasy));
            library.Add(new Book(new Author { Name = "Ray Bradbury" }, "Fahrenheit 451", Genre.Science));
            library.Add(new Book(new Author { Name = "William Bell" }, "Forbidden City", Genre.Science));
            library.Add(new Book(new Author { Name = "Frank Herbert" }, "Dune", Genre.Science));
            List<Book> readerOne = new List<Book>();
            List<Book> readerTwo = new List<Book>();

            foreach (Book book in library.Shelf)
            {
                if (book != null)
                {
                    Console.WriteLine($"{book.Writer.Name} wrote a {book.Genre} novel named {book.Title}");

                    if (book.Genre == Genre.Science)
                    {
                        readerOne.Add(book);
                    }
                    else if (book.Genre == Genre.Fantasy)
                    {
                        readerTwo.Add(book);
                    }
                }
            }


            Console.WriteLine();
            Console.WriteLine("Reader one took:");
            foreach (Book book in readerOne)
            {
                library.Remove(book);
                Console.WriteLine($"A {book.Genre} novel named {book.Title} written by {book.Writer.Name}");
            }


            Console.WriteLine();
            Console.WriteLine("Reader two took:");
            foreach (Book book in readerTwo)
            {
                library.Remove(book);
                Console.WriteLine($"A {book.Genre} novel named {book.Title} written by {book.Writer.Name}");
            }


            Console.WriteLine();
            Console.WriteLine("The library now only contains the following books");
            foreach (Book book in library.Shelf)
            {
                if (book != null) Console.WriteLine($"A {book.Genre} novel named {book.Title} written by {book.Writer.Name}");
            }



        }
    }
}
