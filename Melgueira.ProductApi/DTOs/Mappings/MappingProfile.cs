using AutoMapper;
using Melgueira.ProductApi.Models;
using System.Runtime.InteropServices;

namespace Melgueira.ProductApi.DTOs.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category, CategoryDTO>().ReverseMap();
        CreateMap<Product, ProductDTO>().ReverseMap();
    }
}
