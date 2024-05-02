namespace Melgueira.ProductApi.Models;

public class Category
{
    public int CategoryId { get; set; }
    public string? CategoryName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? LastUpdatedAt { get; set; }
    public ICollection<Product>? Products { get; set; }
}
