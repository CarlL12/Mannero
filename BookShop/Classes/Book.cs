
using BookShop.Interfaces;

namespace BookShop.Classes
{
    public class Book : IBook
    {

        public string author { get; set; } = null!;
        public string title { get; set; } = null!;
        public string isbn { get; set; } = null!;
        public string type { get; set; } = null!;

        public Book(string type, string title, string author, string isbn)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.type = type;

        }
    }
}
