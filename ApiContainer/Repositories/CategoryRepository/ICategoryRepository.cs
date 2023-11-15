using ApiContainer.Models;

namespace ApiContainer.Repositories.CategoryContainer
{
    public interface ICategoryRepository
    {
        List<Category> FindAll();
    }
}
