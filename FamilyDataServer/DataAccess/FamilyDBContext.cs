using System;
using FamilyDataServer.Models;
using Microsoft.EntityFrameworkCore;

namespace FamilyDataServer.DataAccess
{
    public class FamilyDBContext : DbContext
    {
        public DbSet<Adult> Adults { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = C:\Users\kkash\RiderProjects\DNP1Assignment3\FamilyDataServer\Family.db");
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}