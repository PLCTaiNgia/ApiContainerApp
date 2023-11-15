using ApiContainer.Models;

namespace ApiContainer.Services.ContainerService
{
    public interface IContainerService
    {
        List<Container> GetAllContainers();
        Container GetContainerById(string id);
        List<Size> GetListSizeContainer();
    }
}
