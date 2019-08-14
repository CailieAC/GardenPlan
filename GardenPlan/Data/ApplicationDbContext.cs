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

}
