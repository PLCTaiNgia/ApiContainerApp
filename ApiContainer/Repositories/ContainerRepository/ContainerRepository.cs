using ApiContainer.Models;

namespace ApiContainer.Repositories.ContainerRepository
{
    public class ContainerRepository : IContainerRepository
    {

        public bool Create(Container container)
        {
            Data.Containers.Add(container);
            return true;
        }

        public bool Delete(string id)
        {
            var container = this.FindById(id);
            if (container == null)
            {
                return false;
            }

            Data.Containers.Remove(container);
            return true;
        }

        public List<Container> FindAll()
        {
            return Data.Containers;
        }

        public Container FindById(string id)
        {
            var container = Data.Containers.FirstOrDefault(x => x.CntrNo == id);

            return container;
        }

        public List<Size> GetSize()
        {
            Dictionary<int, string> sizeIdMap = new Dictionary<int, string>();

            foreach (var container in Data.Containers)
            {
                if (!sizeIdMap.ContainsKey(container.CntrSize))
                {
                    string newId = Guid.NewGuid().ToString();
                    sizeIdMap.Add(container.CntrSize, newId);
                }
            }

            List<Size> listSize = sizeIdMap.Select(kv => new Size { Id = kv.Value, Value = kv.Key }).ToList<Size>();

            return listSize;
        }

        public bool Update(string id, Container container)
        {
            var containerUpdate = Data.Containers.SingleOrDefault(x => x.CntrNo == id);
            if (containerUpdate == null)
            {
                return false;
            }
            containerUpdate.OprId = container.OprId;
            containerUpdate.CntrSize = container.CntrSize;
            containerUpdate.Status = container.Status;
            containerUpdate.CMStatus = container.CMStatus;
            containerUpdate.Thumbnail = container.Thumbnail;
            return true;
        }
    }
}
