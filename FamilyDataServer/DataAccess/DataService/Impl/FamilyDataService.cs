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
            return await context.Families.Include(f => f.Adults).
                ThenInclude(a => a.JobTitle).
                Include(f => f.Children).
                ThenInclude(c => c.Pets).
                Include(f => f.Children).
                ThenInclude(c => c.Interests)
                .Include(f => f.Pets).
                ToListAsync();
        }

        public async Task<Family> AddFamily(Family family)
        {
            EntityEntry<Family> familyToAdd = await context.Families.AddAsync(family);
            await context.SaveChangesAsync();
            return familyToAdd.Entity;
        }

        public async Task RemoveFamily(int familyId)
        {
            Family familyToRemove = await context.Families.FirstOrDefaultAsync(f => f.Id == familyId);
            if (familyToRemove != null)
            {
                context.Families.Remove(familyToRemove);
                await context.SaveChangesAsync();
            }
        }

        public async Task<Family> UpdateFamily(Family family)
        {
            AdultDataService adultDataService = new AdultDataService(context);
            try
            {
                Family familyToUpdate = await context.Families.Include(f => f.Adults).
                    ThenInclude(a => a.JobTitle).
                    Include(f => f.Children).
                    ThenInclude(c => c.Pets).Include(f => f.Children).
                    ThenInclude(c => c.Interests).
                    Include(f => f.Pets)
                    .FirstAsync(f => f.Id == family.Id);
                familyToUpdate.StreetName = family.StreetName;
                familyToUpdate.HouseNumber = family.HouseNumber;
                context.Update(familyToUpdate);
                await context.SaveChangesAsync();
                return familyToUpdate;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception($"Did not find Family with id: {family.Id}");
            }
            
        }

        public async Task<Family> Get(int familyId)
        {
            return await context.Families.Include(f => f.Adults).
                ThenInclude(a => a.JobTitle).
                Include(f => f.Children).
                ThenInclude(c => c.Pets).Include(f => f.Children).
                ThenInclude(c => c.Interests).
                Include(f => f.Pets)
                .FirstOrDefaultAsync(f => f.Id == familyId);
        }
    }
}