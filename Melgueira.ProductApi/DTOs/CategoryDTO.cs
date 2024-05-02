using Melgueira.ProductApi.Models;
using System.ComponentModel.DataAnnotations;

namespace Melgueira.ProductApi.DTOs;

public class CategoryDTO
{
    public int CategoryId { get; set; }

    [Required(ErrorMessage = "Required Field.")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "The {0} must have at least {2} characters and the maximum length is {1} characters.")]
    [Display(Name = "Name")]
    public string? CategoryName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? LastUpdatedAt { get; set; }
    public ICollection<Product>? Products { get; set; }
}
