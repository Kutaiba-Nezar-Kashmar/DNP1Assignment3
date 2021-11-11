using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using FamilyDataServer.Models;

namespace FamilyDataServer.Data.Impl
{
    public class AdultData : IAdultData
    {
        private string adultFile = "adults.json";
        private IList<Adult> adults;

        public AdultData()
        {
            if (!File.Exists(adultFile))
            {
                writeToJson();
            }
            else
            {
                string content = File.ReadAllText(adultFile);
                adults = JsonSerializer.Deserialize<List<Adult>>(content);
            }
        }

        public async Task<IList<Adult>> GetAdults()
        {
            List<Adult> al = new List<Adult>(adults);
            return al;
        }

        public async Task<Adult> AddAdult(Adult adult)
        {
            int max = adults.Max(adult => adult.Id);
            adult.Id = (++max);
            adults.Add(adult);
            writeToJson();
            return adult;
        }

        public async Task RemoveAdult(int adultId)
        {
            Adult adultToRemove = adults.First(a => a.Id == adultId);
            adults.Remove(adultToRemove);
            writeToJson();
        }

        public async Task<Adult> UpdateAdult(Adult adult)
        {
            Adult toUpdate = adults.FirstOrDefault(a => a.Id == adult.Id);
            if (toUpdate == null)
            {
                throw new Exception($"Did not find Adult with id: {adult.Id}");
            }
            toUpdate.FirstName = adult.FirstName;
            toUpdate.LastName = adult.LastName;
            toUpdate.HairColor = adult.HairColor;
            toUpdate.EyeColor = adult.EyeColor;
            toUpdate.Age = adult.Age;
            toUpdate.Weight = adult.Weight;
            toUpdate.Height = adult.Height;
            toUpdate.Sex = adult.Sex;
            toUpdate.JobTitle.JobTitle = adult.JobTitle.JobTitle;
            toUpdate.JobTitle.Salary = adult.JobTitle.Salary;
            writeToJson();
            return adult;
        }

        public async Task<Adult> Get(int adultId)
        {
            return adults.FirstOrDefault(a => a.Id == adultId);
        }
        
        private void writeToJson()
        {
            string adultsAsJson = JsonSerializer.Serialize(adults);
            File.WriteAllText(adultFile, adultsAsJson);
        }
    }
}