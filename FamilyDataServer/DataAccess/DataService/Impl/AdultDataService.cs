using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyDataServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace FamilyDataServer.DataAccess.DataService.Impl
{
    public class AdultDataService : IAdultService
    {
        private FamilyDBContext context;

        public AdultDataService(FamilyDBContext context)
        {
            this.context = context;
        }

        public async Task<IList<Adult>> GetAdults()
        {
            return await context.Adults.Include(adult => adult.JobTitle).ToListAsync();
        }

        public async Task<Adult> AddAdult(Adult adult)
        {
            EntityEntry<Adult> adultToAdd = await context.Adults.AddAsync(adult);
            await context.SaveChangesAsync();
            return adultToAdd.Entity;
        }

        public async Task RemoveAdult(int adultId)
        {
            Adult adultToRemove = await context.Adults.FirstOrDefaultAsync(a => a.Id == adultId);
            if (adultToRemove != null)
            {
                context.Adults.Remove(adultToRemove);
                await context.SaveChangesAsync();
            }
        }

        public async Task<Adult> UpdateAdult(Adult adult)
        {
            try
            {
                Adult adultToUpdate = await context.Adults.Include(a => a.JobTitle).FirstAsync(a => a.Id == adult.Id);
                adultToUpdate.FirstName = adult.FirstName;
                adultToUpdate.LastName = adult.LastName;
                adultToUpdate.HairColor = adult.HairColor;
                adultToUpdate.EyeColor = adult.EyeColor;
                adultToUpdate.Age = adult.Age;
                adultToUpdate.Weight = adult.Weight;
                adultToUpdate.Height = adult.Height;
                adultToUpdate.Sex = adult.Sex;
                adultToUpdate.JobTitle.JobTitle = adult.JobTitle.JobTitle;
                adultToUpdate.JobTitle.Salary = adult.JobTitle.Salary;
                context.Update(adultToUpdate);
                await context.SaveChangesAsync();
                return adultToUpdate;
            }
            catch (Exception e)
            {
                throw new Exception($"Did not find Adult with id: {adult.Id}");
            }
        }

        public async Task<Adult> Get(int adultId)
        {
            return await context.Adults.Include(adult => adult.JobTitle).FirstOrDefaultAsync(a => a.Id == adultId);
        }
    }
}