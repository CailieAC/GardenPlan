using GardenPlan.Data;
using GardenPlan.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GardenPlan.ViewModels.Plant
{
    public class PlantCreateViewModel
    {
        public int Id { get; set; }
        public string PlantName { get; set; }
        public PlantCategory PlantCategory { get; set; }
        public DateTime PlantDate { get; set; }
        public DateTime HarvestDate { get; set; }
        public Sun Sun { get; set; }
        public string Spacing { get; set; }
        public Duration Duration { get; set; }
        public int MaxTemp { get; set; }
        public int MinTemp { get; set; }
     

        public void Persist(ApplicationDbContext context)
        {
            Models.Plant plant = new Models.Plant
            {
                PlantName = this.PlantName,
                PlantCategory = this.PlantCategory,
                PlantDate = this.PlantDate,
                HarvestDate = this.HarvestDate,
                Sun = this.Sun,
                Spacing = this.Spacing,
                Duration = this.Duration,
                MaxTemp = this.MaxTemp,
                MinTemp = this.MinTemp
            };
            context.Plants.Add(plant);
        }
    }
}
