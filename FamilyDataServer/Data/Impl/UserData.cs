using System.Threading.Tasks;
using FamilyDataServer.DataAccess;
using FamilyDataServer.DataAccess.DataService;
using FamilyDataServer.DataAccess.DataService.Impl;
using FamilyDataServer.Models;

namespace FamilyDataServer.Data.Impl
{
    public class UserData : IUserData
    {
        private IUserService dataService;
        private FamilyDBContext familyDbContext;
        public UserData()
        {
            familyDbContext = new FamilyDBContext();
            dataService = new UserService(familyDbContext);
        }

        public async Task<User> CreateUser(User user)
        {
            return await dataService.CreateUser(user);
        }
        public async Task<User> ValidateUser(string userName, string password)
        {
            return await dataService.ValidateUser(userName, password);
        }
    }
}