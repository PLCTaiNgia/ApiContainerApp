using ApiContainer.Models;

namespace ApiContainer.Repositories.ContainerRepository
{
    public interface IContainerRepository
    {
        List<Container> FindAll();
        Container FindById(string id);
        bool Create(Container container);
        bool Update(string id, Container container);
        bool Delete(string id);
        List<Size> GetSize();
    }
}
