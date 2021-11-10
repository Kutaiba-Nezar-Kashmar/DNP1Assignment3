using System.Threading.Tasks;
using DNP1Assignment3.Models;

namespace DNP1Assignment3.Data
{
    public interface IUserService
    {
        Task CreateUser(User user);
        Task<User> ValidateUser(string userName, string password);
    }
}