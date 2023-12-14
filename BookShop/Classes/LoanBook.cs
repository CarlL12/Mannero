
using BookShop.Interfaces;

namespace BookShop.Classes
{
    public class LoanBook : ILoanBook
    {
        public string author { get; set; } = null!;
        public string title { get; set; } = null!;
        public string isbn { get; set; } = null!;

        public int DueDate { get; set; }
        public string type { get; set; } = null!;

        public LoanBook(string type, string author, string title, string isbn,int DueDate)
        {
            this.author = author;
            this.title = title;
            this.isbn = isbn;
            this.DueDate = DueDate;
            this.type = type;
        }
    }
}
