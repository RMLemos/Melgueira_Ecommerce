using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Melgueira.Web.Models;

public class ProductViewModel
{
    public int ProductId { get; set; }
    public string? ProductName { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? ImageURL { get; set; }
    public long Stock { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? LastUpdatedAt { get; set; }
    public string? CategoryName { get; set; }
    public int CategoryId { get; set; }
}
