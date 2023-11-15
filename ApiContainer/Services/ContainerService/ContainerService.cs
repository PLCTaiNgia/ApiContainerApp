using ApiContainer.Models;
using ApiContainer.Repositories.ContainerRepository;

namespace ApiContainer.Services.ContainerService
{
    public class ContainerService : IContainerService
    {
        private readonly IContainerRepository containerRepository;

        public ContainerService(IContainerRepository containerRepository)
        {
            this.containerRepository = containerRepository;
        }

        public List<Container> GetAllContainers()
        {
            return containerRepository.FindAll();
        }

        public Container GetContainerById(string id)
        {
            return containerRepository.FindById(id);
        }

        public List<Size> GetListSizeContainer()
        {
            return containerRepository.GetSize();
        }
    }
}
