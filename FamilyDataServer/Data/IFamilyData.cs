using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyDataServer.Models;

namespace FamilyDataServer.Data
{
    public interface IFamilyData
    {
        Task<IList<Family>> GetFamilies();
        Task<Family> AddFamily(Family family);
        Task RemoveFamily(int familyId);
        Task<Family> UpdateFamily(Family family);
        Task<Family> Get(int familyId);
    }
}