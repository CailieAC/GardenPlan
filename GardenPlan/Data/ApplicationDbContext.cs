using System;
using System.Collections.Generic;
using System.Text;
using GardenPlan.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GardenPlan.ViewModels.Plant;

namespace GardenPlan.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Plant> Plants { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        // Change column name to PersonId
        modelBuilder.Entity<Plant>()
            .Property(p => p.PlantTime)
            .HasColumnName("PlantDate");

        // Change table name to People
        modelBuilder.Entity<Plant>()
            .Property(p => p.HarvestTime)
            .HasColumnName("HarvestDate");
    }
}
