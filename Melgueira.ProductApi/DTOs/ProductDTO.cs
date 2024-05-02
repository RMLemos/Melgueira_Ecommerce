using Melgueira.ProductApi.Models;
using System.ComponentModel.DataAnnotations;

namespace Melgueira.ProductApi.DTOs;

public class ProductDTO
{
    public int ProductId { get; set; }

    [Required(ErrorMessage = "Required Field.")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "The {0} must have at least {2} characters and the maximum length is {1} characters.")]
    [Display(Name = "Name")]
    public string? ProductName { get; set; }

    [Required(ErrorMessage = "Required Field.")]
    [StringLength(200, MinimumLength = 3, ErrorMessage = "The {0} must have at least {2} characters and the maximum length is {1} characters.")]
    [Display(Name = "Description")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "Required Field.")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Required Field.")]
    public string? ImageURL { get; set; }

    [Required(ErrorMessage = "Required Field.")]
    [Range(1, 9999)]
    public long Stock { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? LastUpdatedAt { get; set; }
    public Category? Category { get; set; }
    public int CategoryId { get; set; }
}
