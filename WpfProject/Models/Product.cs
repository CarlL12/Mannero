
namespace WpfProject.Models;

public class Product
{
    public string ArticleNumber { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null !;
    public decimal Price { get; set; }
}
