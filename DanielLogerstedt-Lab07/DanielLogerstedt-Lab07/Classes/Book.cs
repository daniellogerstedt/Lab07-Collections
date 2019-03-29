using System;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Classes
{
    public class Book
    {
        string Author;
        string Title;
        int Genre;

        public Book(string author, string title, int genre)
        {
            Author = author;
            Title = title;
            Genre = genre;
        }
    }
}
