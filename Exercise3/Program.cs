using Exercise3.Menu;
using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddBook(new Book("Titulo", "ISBN"));
            library.AddBook(new Book("Titul2", "ISBN2"));

            LibraryMenu libraryMenu = new LibraryMenu(library);
            try
            {
                libraryMenu.Menu();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error. The app will close.");
            }
        }
    }
}
