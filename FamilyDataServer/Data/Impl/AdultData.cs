using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyDataServer.DataAccess;
using FamilyDataServer.DataAccess.DataService;
using FamilyDataServer.DataAccess.DataService.Impl;
using FamilyDataServer.Models;

namespace FamilyDataServer.Data.Impl
{
    public class AdultData : IAdultData
    {
        private IAdultService dataService;
        private FamilyDBContext familyDbContext;
        public AdultData()
        {
            familyDbContext = new FamilyDBContext();
            dataService = new AdultDataService(familyDbContext);
        }

        public async Task<IList<Adult>> GetAdults()
        {
            return await dataService.GetAdults();
        }

        public async Task<Adult> AddAdult(Adult adult)
        {
            return await dataService.AddAdult(adult);
        }

        public async Task RemoveAdult(int adultId)
        {
            await dataService.RemoveAdult(adultId);
        }

        public async Task<Adult> UpdateAdult(Adult adult)
        {
            return await dataService.UpdateAdult(adult);
        }

        public async Task<Adult> Get(int adultId)
        {
            return await dataService.Get(adultId);
        }
    }
}