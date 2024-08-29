using Exercise3.LibraryExceptions;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    public class Library
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

        public string RemoveBook(string isbn)
        {
            Book removeBook = GetBook(isbn);
            if (removeBook == null)
            {
                throw new BookNotFoundException("The book yo want to remove does not exist.");
            }
            _books.Remove(removeBook);
            return $"The book {removeBook.Title} has been removed from the library.";
        }

        public string CheckOutBook(string isbn)
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
            return $"The book {book.Title} is now ckecked out.";
        }

        public string ReturnBook(string isbn)
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
            return $"The book {book.Title} was successfully returned.";
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

        public string ListAllBooks()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(Book book in _books)
            {
                stringBuilder.AppendLine("------------------------------")
                    .AppendLine(book.ToString());
            }
            stringBuilder.AppendLine("------------------------------");

            return stringBuilder.ToString();
        }
    }
}
