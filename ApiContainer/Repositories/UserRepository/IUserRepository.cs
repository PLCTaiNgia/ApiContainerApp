using ApiContainer.Models;

namespace ApiContainer.Repositories.UserRepository
{
    public interface IUserRepository
    {
        public List<User> FindAll();
        public User FindById(int id);
        public User FindByUsername(string username);
        public bool CreateUser(User user);
        public bool UpdateUser(int id, User user);
    }
}
