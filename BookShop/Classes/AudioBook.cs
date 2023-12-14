

using BookShop.Interfaces;

namespace BookShop.Classes
{
    public class AudioBook : IBook
    {
        public string author { get; set; } = null!;
        public string title { get; set; } = null!;
        public string isbn { get; set; } = null!;

        public int duration { get; set; } = 0;
        public string type { get; set; } = null!;

        public AudioBook (string type, string author, string title, string isbn, int duration)
        {
            this.author = author;
            this.title = title;
            this.isbn = isbn;
            this.duration = duration;
            this.type = type;
        }
    }
}
