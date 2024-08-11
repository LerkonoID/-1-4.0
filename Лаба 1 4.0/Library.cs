using System;
using System.Collections.Generic;
using System.Linq;

namespace Лабараторна_1_3._0
{
    internal class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(string isbn)
        {
            books.RemoveAll(b => b.ISBN == isbn);
        }

        public List<Book> SearchByAuthor(string author)
        {
            return books.Where(b => b.Author.ToLower().Contains(author.ToLower())).ToList();
        }

        public List<Book> SearchByTitle(string title)
        {
            return books.Where(b => b.Title.ToLower().Contains(title.ToLower())).ToList();
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }
    }
}
