﻿using Melgueira.Web.Models;

namespace Melgueira.Web.Services.Contratcts;

public interface IProductService
{
    Task<IEnumerable<ProductViewModel>> GetAllProducts();
    Task<ProductViewModel> FindProductById(int id);
    Task<ProductViewModel> CreateProduct (ProductViewModel productVM);
    Task<ProductViewModel> UpdateProduct (ProductViewModel productVM);
    Task<bool> DeleteProductById(int id);
}
