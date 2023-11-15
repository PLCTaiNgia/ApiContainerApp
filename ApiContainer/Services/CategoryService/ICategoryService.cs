using ApiContainer.Models;

namespace ApiContainer.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
    }
}
