using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyDataServer.Models;

namespace FamilyDataServer.DataAccess.DataService
{
    public interface IFamilyService
    {
        Task<IList<Family>> GetFamilies();
        Task<Family> AddFamily(Family family);
        Task RemoveFamily(int familyId);
        Task<Family> UpdateFamily(Family family);
        Task<Family> Get(int familyId);
    }
}