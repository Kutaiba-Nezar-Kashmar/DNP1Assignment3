using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using FamilyDataServer.DataAccess;
using FamilyDataServer.DataAccess.DataService;
using FamilyDataServer.DataAccess.DataService.Impl;
using FamilyDataServer.Models;

namespace FamilyDataServer.Data.Impl
{
    public class FamilyData : IFamilyData
    {
        private FamilyDBContext familyDbContext;
        private IFamilyService dataService;
        public FamilyData()
        {
            familyDbContext = new FamilyDBContext();
            dataService = new FamilyDataService(familyDbContext);
        }

        public async Task<IList<Family>> GetFamilies()
        {
            return await dataService.GetFamilies();
        }

        public async Task<Family> AddFamily(Family family)
        {
            return await dataService.AddFamily(family);
        }

        public async Task RemoveFamily(int familyId)
        {
            await dataService.RemoveFamily(familyId);
        }

        public async Task<Family> UpdateFamily(Family family)
        {
            return await dataService.UpdateFamily(family);
        }

        public async Task<Family> Get(int familyId)
        {
            return await dataService.Get(familyId);
        }
    }
}