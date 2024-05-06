using Melgueira.Web.Models;

namespace Melgueira.Web.Services.Contratcts;

public interface ICategoryService
{
    Task<IEnumerable<CategoryViewModel>> GetAllCategories();
}
