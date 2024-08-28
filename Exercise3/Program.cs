using System;
using System.Collections.Generic;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isbnToRemove;
            Library library = new Library();
            library.AddBook(new Book("Titulo", "ISBN"));
            library.AddBook(new Book("Titul2", "ISBN2"));

            library.ListAllBooks();

            try
            {
                Console.WriteLine("Enter isbn of the book to remove.");
                isbnToRemove = Console.ReadLine();

                library.RemoveBook(isbnToRemove);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
