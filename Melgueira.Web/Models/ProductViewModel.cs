using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Melgueira.Web.Models;

public class ProductViewModel
{
    public int ProductId { get; set; }

    [Required]
    public string? ProductName { get; set; }

    [Required]
    public string? Description { get; set; }

    [Required]
    public decimal Price { get; set; }

    [Required]
    public string? ImageURL { get; set; }

    [Required]
    public long Stock { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? LastUpdatedAt { get; set; }
    public string? CategoryName { get; set; }
    public int CategoryId { get; set; }
}
