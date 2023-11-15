using ApiContainer.Models;

namespace ApiContainer.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        public bool CreateUser(User user)
        {
            Data.users.Add(user);
            return true;
        }

        public List<User> FindAll()
        {
            return Data.users;
        }

        public User FindById(int id)
        {
            return Data.users.FirstOrDefault(x => x.Id == id);
        }

        public User FindByUsername(string username)
        {
            return Data.users.FirstOrDefault(x => x.Username.ToUpper().Equals(username.ToUpper()));
        }

        public bool UpdateUser(int id, User user)
        {
            var result = this.FindById(id);
            if (result == null)
                return false;

            result = user;
            return true;
        }
    }
}
