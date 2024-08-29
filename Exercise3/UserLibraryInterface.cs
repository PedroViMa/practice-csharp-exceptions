using System;

namespace Exercise3.Menu
{
    public static class UserLibraryInterface
    {

        public static void ShowLibraryMenu(Library library)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("============ The Library ============");
            Console.WriteLine("=====================================");

            Console.WriteLine();
            Console.WriteLine(library.ListAllBooks());
            Console.WriteLine();

            Console.WriteLine("What you want to do?");
            ShowMainMenu();
        }

        private static void ShowMainMenu()
        {
            Console.WriteLine("1. Add book to the library");
            Console.WriteLine("2. Remove book from the library");
            Console.WriteLine("3. Check out a book from the library");
            Console.WriteLine("4. Return a book to the library");
            Console.WriteLine("5. Exit");
        }

        public static Book RequuestBook()
        {
            Console.WriteLine("Please enter the Title of the book:");
            string title = Console.ReadLine();
            Console.WriteLine("Now enter the ISBN of the book:");
            string isbn = Console.ReadLine();

            return new Book(title, isbn);
        }

        public static string RequestISBN(string message)
        {
            Console.WriteLine("Enter the ISBN of the book to " + message);
            string isbn = Console.ReadLine();

            return isbn;
        }
    }
}
