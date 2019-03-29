using System;
using System.Collections.Generic;
using LendingLibrary.Classes;
using LendingLibrary.Enums;
using System.Text;

namespace LendingLibrary.Classes
{
    public class Book
    {
        public Author Writer;
        public string Title;
        public Genre Genre;

        public Book(Author writer, string title, Genre genre)
        {
            Writer = writer;
            Title = title;
            Genre = genre;
        }
    }
}
