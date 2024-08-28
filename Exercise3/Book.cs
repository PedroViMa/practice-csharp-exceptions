namespace Exercise3
{
    internal class Book
    {
        public string Title { get; }
        public string ISBN { get; }
        public bool IsCheckedOut { get; set; }

        public Book(string title, string isbn)
        {
            Title = title;
            ISBN = isbn;
            IsCheckedOut = false;
        }
    }
}
