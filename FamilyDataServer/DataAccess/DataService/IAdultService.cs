using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyDataServer.Models;

namespace FamilyDataServer.DataAccess.DataService
{
    public interface IAdultService
    {
        Task<IList<Adult>> GetAdults();
        Task<Adult> AddAdult(Adult adult);
        Task RemoveAdult(int adultId);
        Task<Adult> UpdateAdult(Adult adult);
        Task<Adult> Get(int adultId);
    }
}