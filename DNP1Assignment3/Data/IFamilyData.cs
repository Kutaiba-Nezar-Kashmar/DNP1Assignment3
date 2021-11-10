using System.Collections.Generic;
using System.Threading.Tasks;
using DNP1Assignment3.Models;

namespace DNP1Assignment3.Data
{
    public interface IFamilyData
    {
        Task<IList<Family>> GetFamilies();
        Task AddFamily(Family family);
        Task RemoveFamily(int familyId);
        Task UpdateFamily(Family family);
        Task<Family> Get(int familyId);
    }
}