namespace Exercise3
{
    public class Book
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

        public override string ToString() =>
            $"Title: {Title}, ISBN: {ISBN}";
    }
}
