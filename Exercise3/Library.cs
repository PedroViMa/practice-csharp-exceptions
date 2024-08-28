using System;
using System.Collections.Generic;

namespace Exercise3
{
    internal class Library
    {
        private readonly List<Book> _books;

        public Library()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void RemoveBook(string isbn)
        {
            Book removeBook = GetBook(isbn);
            if (removeBook == null)
            {
                throw new BookNotFoundException("The book yo want to remove does not exist.");
            }
            _books.Remove(removeBook);
        }

        public void CheckOutBook(string isbn)
        {
            Book book = GetBook(isbn);

            if (book == null)
            {
                throw new BookNotFoundException("The book yo want to check out does not exist.");
            }
            if (book.IsCheckedOut)
            {
                throw new BookAlreadyCheckedOutException("The book is not available.");
            }

            book.IsCheckedOut = true;
        }

        public void ReturnBook(string isbn)
        {
            Book book = GetBook(isbn);

            if (book == null)
            {
                throw new BookNotFoundException("The book yo want to return does not exist.");
            }
            if (!book.IsCheckedOut)
            {
                throw new BookNotCheckedOutException("The book is not checked out.");
            }

            book.IsCheckedOut = true;
        }

        public Book GetBook(string isbn)
        {
            foreach (Book book in _books)
            {
                if(isbn.Equals(book.ISBN))
                {
                    return book;
                }
            }
            return null;
        }

        public void ListAllBooks()
        {
            foreach(Book book in _books)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Title: {book.ISBN}");
            }
        }
    }
}
