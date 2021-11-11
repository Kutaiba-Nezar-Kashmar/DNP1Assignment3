using System.Threading.Tasks;
using FamilyDataServer.Models;

namespace FamilyDataServer.Data
{
    public interface IUserData
    {
        Task<User> CreateUser(User user);
        Task<User> ValidateUser(string userName, string password);
    }
}