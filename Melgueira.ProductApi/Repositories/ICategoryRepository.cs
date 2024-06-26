﻿using Melgueira.ProductApi.Models;
using System.Collections.Generic;

namespace Melgueira.ProductApi.Repositories;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAll();
    Task<IEnumerable<Category>> GetById();
    Task<Category> GetById(int id);
    Task<Category> Create(Category category);
    Task<Category> Update(Category category);
    Task<Category> Delete(int id);
}
