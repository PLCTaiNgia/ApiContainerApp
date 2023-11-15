using ApiContainer.Models;

namespace ApiContainer.Repositories.CategoryContainer
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<Category> FindAll()
        {
            return Data.categories;
        }
    }
}
