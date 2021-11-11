using System.Threading.Tasks;
using FamilyDataServer.Models;

namespace FamilyDataServer.DataAccess.DataService
{
    public interface IUserService
    {
        Task<User> CreateUser(User user);
        Task<User> ValidateUser(string userName, string password);
    }
}