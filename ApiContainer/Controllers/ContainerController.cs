using ApiContainer.Common;
using ApiContainer.Models;
using ApiContainer.Services.ContainerService;
using Microsoft.AspNetCore.Mvc;

namespace ApiContainer.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ContainerController : Controller
    {
        private readonly IContainerService containerService;

        public ContainerController(IContainerService containerService)
        {
            this.containerService = containerService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var containers = this.containerService.GetAllContainers();
            if (containers == null)
            {
                return Ok(new ResponseApi<String>(success: true, message: "List container empty", data: null));
            }
            return Ok(new ResponseApi<List<Container>>(success: true, message: "Get all containers successfully", data: containers));
        }

        [HttpGet("{id}")]
        public IActionResult Details(string id)
        {
            var container = this.containerService.GetContainerById(id);


            return Ok(new ResponseApi<Container>(true, "Get container successfully", container));
        }

        [HttpGet("ListSize")]
        public IActionResult GetListSize()
        {
            var listSize = this.containerService.GetListSizeContainer();


            return Ok(new ResponseApi<List<Size>>(true, "Get list size successfully", listSize));
        }

    }
}
