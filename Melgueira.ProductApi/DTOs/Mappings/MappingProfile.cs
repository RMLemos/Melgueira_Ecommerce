using AutoMapper;
using Melgueira.ProductApi.Models;
using System.Runtime.InteropServices;

namespace Melgueira.ProductApi.DTOs.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category, CategoryDTO>().ReverseMap();
        CreateMap<ProductDTO, Product>();
        CreateMap<Product, ProductDTO>().ForMember(c=>c.CategoryName, opt=> opt.MapFrom(src => src.Category.CategoryName));
    }
}
