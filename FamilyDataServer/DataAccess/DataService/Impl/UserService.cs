using System.Linq;
using System.Threading.Tasks;
using FamilyDataServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace FamilyDataServer.DataAccess.DataService.Impl
{
    public class UserService : IUserService
    {
        private FamilyDBContext context;

        public UserService(FamilyDBContext context)
        {
            this.context = context;
        }

        public async Task<User> CreateUser(User user)
        {
            EntityEntry<User> userToAdd = await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
            return userToAdd.Entity;
        }

        public async Task<User> ValidateUser(string userName, string password)
        {
            return await context.Users.FirstAsync(user => user.UserName == userName && user.Password == password);
        }
    }
}