using System.ComponentModel.DataAnnotations;

namespace Melgueira.Web.Models;

public class CategoryViewModel
{
    public int CategoryId { get; set; }
    public string? CategoryName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? LastUpdatedAt { get; set; }
}
