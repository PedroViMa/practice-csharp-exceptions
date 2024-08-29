using Exercise3.LibraryExceptions;
using System;

namespace Exercise3.Menu
{
    public class LibraryMenu
    {
        private enum MainMenu
        {
            AddBook = 1,
            RemoveBook = 2,
            CheckOutBook = 3,
            ReturnBook = 4,
            Exit = 5
        }

        private Library Library { get; }

        public LibraryMenu(Library library)
        {
            Library = library;
        }

        public void Menu()
        {
            MainMenu menu;
            do
            {
                UserLibraryInterface.ShowLibraryMenu(Library);
                menu = GetMenuOption();
                switch (menu)
                {
                    case MainMenu.AddBook:
                        AddBookOption(); break;
                    case MainMenu.RemoveBook:
                        RemoveBookOption(); break;
                    case MainMenu.CheckOutBook:
                        CheckOutBookOption(); break;
                    case MainMenu.ReturnBook:
                        ReturnBookOption(); break;
                }
            }
            while (menu != MainMenu.Exit);
        }

        private MainMenu GetMenuOption()
        {
            int opt = ConsoleScanner.ScanBetweenRangeOfIntegers(1, 5);
            return (MainMenu) opt;
        }

        private void AddBookOption()
        {
            Book book = UserLibraryInterface.RequuestBook();
            Library.AddBook(book);
        }

        private void RemoveBookOption()
        {
            string isbn = UserLibraryInterface.RequestISBN("remove:");
            try
            {
                Library.RemoveBook(isbn);
            }
            catch (BookNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CheckOutBookOption()
        {
            string isbn = UserLibraryInterface.RequestISBN("check out:");
            try
            {
                Library.CheckOutBook(isbn);
            }
            catch (BookNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (BookAlreadyCheckedOutException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ReturnBookOption()
        {
            string isbn = UserLibraryInterface.RequestISBN("return:");
            try
            {
                Library.ReturnBook(isbn);
            }
            catch (BookNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (BookNotCheckedOutException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
