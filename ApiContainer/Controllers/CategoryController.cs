using ApiContainer.Common;
using ApiContainer.Models;
using ApiContainer.Services.CategoryService;
using Microsoft.AspNetCore.Mvc;

namespace ApiContainer.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var categories = this.categoryService.GetCategories();
            return Ok(new ResponseApi<List<Category>>(true, "Get All Categories successfully", categories));
        }
    }
}
