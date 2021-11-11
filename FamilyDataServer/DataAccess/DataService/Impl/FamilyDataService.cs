using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FamilyDataServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace FamilyDataServer.DataAccess.DataService.Impl
{
    public class FamilyDataService : IFamilyService
    {
        private FamilyDBContext context;

        public FamilyDataService(FamilyDBContext context)
        {
            this.context = context;
        }

        public async Task<IList<Family>> GetFamilies()
        {
            return await context.Families.Include(family => family.Adults).Include(family => family.Children)
                .Include(family => family.Pets).ToListAsync();
        }

        public async Task<Family> AddFamily(Family family)
        {
            EntityEntry<Family> familyToAdd = await context.Families.AddAsync(family);
            await context.SaveChangesAsync();
            return familyToAdd.Entity;
        }

        public async Task RemoveFamily(int familyId)
        {
            Family familyToRemove = await context.Families.FirstOrDefaultAsync(family => family.Id == familyId);
            if (familyToRemove != null)
            {
                context.Families.Remove(familyToRemove);
                await context.SaveChangesAsync();
            }
        }

        public async Task<Family> UpdateFamily(Family family)
        {
            try
            {
                Family familyToUpdate = await context.Families.Include(f => f.Adults)
                    .Include(f => f.Children).Include(f => f.Pets)
                    .FirstAsync(f => f.Id == family.Id);
                familyToUpdate.StreetName = family.StreetName;
                familyToUpdate.HouseNumber = family.HouseNumber;
                familyToUpdate.Adults = family.Adults;
                familyToUpdate.Children = family.Children;
                familyToUpdate.Pets = family.Pets;
                context.Update(familyToUpdate);
                await context.SaveChangesAsync();
                return familyToUpdate;
            }
            catch (Exception e)
            {
                throw new Exception($"Did not find Family with id: {family.Id}");
            }
        }

        public async Task<Family> Get(int familyId)
        {
            return await context.Families.Include(f => f.Adults).Include(f => f.Children).Include(f => f.Pets)
                .FirstOrDefaultAsync(f => f.Id == familyId);
        }
    }
}