namespace SampleOperator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var book = new Book()
            {
                Name = "Mostafa",
                Author = "Cloner",
                CreateDate = DateTime.Now
            };

            //NoteBook noteBook = new NoteBook();

            //noteBook = book;

            var noteBook = (NoteBook)book;

            Console.WriteLine("Name : {0} , Author : {1}", noteBook.Name, noteBook.Author);

        }

    }
}

public class Book
{
    public string Name { get; set; }

    public string Author { get; set; }

    public DateTime CreateDate { get; set; }
}

public class NoteBook
{
    public string Name { get; set; }

    public string Author { get; set; }

    public static explicit operator NoteBook(Book book)
    {
        return new NoteBook()
        {
            Author = book.Author,
            Name = book.Name
        };
    }

    //public static implicit operator NoteBook(Book book)
    //{
    //    return new NoteBook()
    //    {
    //        Author = book.Author,
    //        Name = book.Name
    //    };
    //}
}
