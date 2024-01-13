using VivatInternship.Backend.Data;
using VivatInternship.Backend.Models;
using VivatInternship.Backend.Models.User;

namespace VivatInternship.Backend.Interfaces
{
    public interface IUserService
    {
        UserModel Authenticate(LoginModel model);
        IEnumerable<User> GetAll();
        User GetById(int id);
        void Register(RegisterModel model);
        void Update(int id, UpdateModel model);
        void Delete(int id);
    }
}
