using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using FamilyDataServer.Models;

namespace FamilyDataServer.Data.Impl
{
    public class FamilyData : IFamilyData
    {
        private string familyFile = "families.json";
        private IList<Family> families = new List<Family>();
        
        public FamilyData()
        {
            if (!File.Exists(familyFile))
            {
                WriteFamiliesToFile();
            }
            else
            {
                string content = File.ReadAllText(familyFile);
                families = JsonSerializer.Deserialize<List<Family>>(content);
            }
        }

        public async Task<IList<Family>> GetFamilies()
        {
            List<Family> fl = new List<Family>(families);
            return fl;
        }

        public async Task<Family> AddFamily(Family family)
        {
            int max = families.Max(family => family.Id);
            family.Id = (++max);
            families.Add(family);
            WriteFamiliesToFile();
            return family;
        }

        public async Task RemoveFamily(int familyId)
        {
            Family familyToRemove = families.First(f => f.Id == familyId);
            families.Remove(familyToRemove);
            WriteFamiliesToFile();
        }

        public async Task<Family> UpdateFamily(Family family)
        {
            Family toUpdate = families.First(f => f.Id == family.Id);
            toUpdate.StreetName = family.StreetName;
            toUpdate.HouseNumber = family.HouseNumber;
            toUpdate.Adults = family.Adults;
            toUpdate.Children = family.Children;
            toUpdate.Pets = family.Pets;
            WriteFamiliesToFile();
            return family;
        }

        public async Task<Family> Get(int familyId)
        {
            return families.FirstOrDefault(f => f.Id == familyId);
        }

        private void WriteFamiliesToFile()
        {
            string familiesAsJson = JsonSerializer.Serialize(families);
            File.WriteAllText(familyFile, familiesAsJson);
        }
    }
}