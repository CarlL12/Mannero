
namespace BookShop.Interfaces
{
    public interface IBook
    {
        string author { get; set; }
        string title { get; set; }
        string isbn { get; set; }
    
        string type { get; set; }
    }
}
