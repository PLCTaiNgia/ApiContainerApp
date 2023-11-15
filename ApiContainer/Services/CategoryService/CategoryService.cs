using ApiContainer.Models;
using ApiContainer.Repositories.CategoryContainer;

namespace ApiContainer.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public List<Category> GetCategories()
        {
            return this.categoryRepository.FindAll();
        }
    }
}
