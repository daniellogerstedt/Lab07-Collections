using System;
using Xunit;
using LendingLibrary.Classes;
using LendingLibrary.Enums;

namespace TestCollections
{
    public class UnitTest1
    {
        [Fact]
        public void AddBookToLibrary()
        {
            Library<Book> library = new Library<Book>();
            Assert.Null(library.Shelf[0]);
            Book book = new Book(new Author { Name = "Test" }, "Test", Genre.Science);
            library.Add(book);
            Assert.Equal(book, library.Shelf[0]);
        }


        [Fact]
        public void RemoveBookFromLibrary()
        {
            Library<Book> library = new Library<Book>();
            Assert.Null(library.Shelf[0]);
            Book book = new Book(new Author { Name = "Test" }, "Test", Genre.Science);
            library.Add(book);
            Assert.Equal(book, library.Shelf[0]);
            library.Remove(book);
            Assert.Null(library.Shelf[0]);
        }

        [Fact]
        public void CannotRemoveBooksNotInLibrary()
        {
            Library<Book> library = new Library<Book>();
            Assert.Null(library.Shelf[0]);
            Book book = new Book(new Author { Name = "Test" }, "Test", Genre.Science);
            Book otherBook = new Book(new Author { Name = "Not The Book" }, "Not The Book", Genre.Science);
            library.Add(book);
            library.Remove(otherBook);
            Assert.Equal(book, library.Shelf[0]);
        }

        [Fact]
        public void GetterSetterBook()
        { 
            Book book = new Book(new Author { Name = "Test" }, "Test", Genre.Science);
            Assert.Equal(Genre.Science, book.Genre);
            book.Genre = Genre.Horror;
            Assert.Equal(Genre.Horror, book.Genre);
        }

        [Fact]
        public void GetterSetterAuthor()
        {
            Author author = new Author { Name = "Test" };
            Assert.Equal("Test", author.Name);
            author.Name = "New Test";
            Assert.Equal("New Test", author.Name);
        }

        [Fact]
        public void CountBooks()
        {
            Library<Book> library = new Library<Book>();
            Assert.Equal(0, library.Count());
            Book book = new Book(new Author { Name = "Test" }, "Test", Genre.Science);
            Book otherBook = new Book(new Author { Name = "Not The Book" }, "Not The Book", Genre.Science);
            library.Add(book);
            library.Add(otherBook);
            Assert.Equal(2, library.Count());
        }

        [Fact]
        public void TryingToRemoveNullDoesNotThrow()
        {
            Library<Book> library = new Library<Book>();
            library.Add(new Book(new Author { Name = "Test" }, "Test", Genre.Science));
            try
            {
                library.Remove(null);
            }
            catch (Exception)
            {
                Assert.True(false);
            }
            Assert.True(true);
        }
    }
}
