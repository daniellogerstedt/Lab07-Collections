using System;
using LendingLibrary.Classes;

namespace LendingLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Library<Book> library = new Library<Book>();

            library.Add(new Book("Red Fish, Blue Fish, One Fish, Two Fish", "Dr. Suess", 4));
            library.Add(new Book("1984", "George Orwell", 1));
            library.Add(new Book("Existential", "Ryan W. Aslesen", 1));
            library.Add(new Book("Fellowship of the Ring", "Tolkien", 2));
            library.Add(new Book("The Two Towers", "Tolkien", 2));
            library.Add(new Book("Return of the King", "Dr. Suess", 2));
            library.Add(new Book("Animal Farm", "George Orwell", 1));
            library.Add(new Book("Fahrenheit 451", "Ray Bradbury", 1));
            library.Add(new Book("Forbidden City", "William Bell", 1));
            library.Add(new Book("Dune", "Frank Herbert", 1));



        }
    }
}
