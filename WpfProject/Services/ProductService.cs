
using WpfProject.Models;

namespace WpfProject.Services;

public class ProductService
{
    public List<Product> Products { get; private set;} = [];

    public bool Add(Product product)
    {
        if (product == null)
        {
            return false;
        }
        else
        {
            Products.Add(product);
            return true;
        }
    }
    public IEnumerable<Product> GetProducts()
    {
        return Products;
    }

    public Product GetOne(Func<Product, bool> predicate)
    {
        var product = Products.FirstOrDefault(predicate);
        return product ?? null!;
    }

    public Product Update(Product product)
    {
        var existingProduct = GetOne(x => x.ArticleNumber == product.ArticleNumber);
        if (existingProduct != null)
        {
            existingProduct.ArticleNumber = product.ArticleNumber;
            existingProduct.Title = product.Title;
            existingProduct.Description = product.Description;

            return existingProduct;
        }
        return null!;
    }

    public bool Remove(Product product)
    {
        if(!Products.Contains(product))
        {
            return false;
        }
        else
        {
            Products.Remove(product);
            return true;
        }
    }
    
    public bool Exists(Func<Product, bool> predicate)
    {
        return Products.Any(predicate);
    }
}
