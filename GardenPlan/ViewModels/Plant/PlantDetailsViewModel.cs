using GardenPlan.Data;
using GardenPlan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GardenPlan.ViewModels.Plant
{
    public class PlantDetailsViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string PlantName { get; set; }
        public PlantCategory Category { get; set; }
        [Display(Name = "When to Plant")]
        public string PlantTime { get; set; }
        [Display(Name = "When to Harvest")]
        public string HarvestTime { get; set; }
        public Sun Sun { get; set; }
        [Display(Name = "Spacing (inches)")]
        public string Spacing { get; set; }
        public Duration Duration { get; set; }
        [Display(Name = "Maximum Temperature (°F)")]
        public int MaxTemp { get; set; }
        [Display(Name = "Minimum Temperature (°F)")]
        public int MinTemp { get; set; }

        public static PlantDetailsViewModel GetPlant(int? id, ApplicationDbContext context)
        {
            return context.Plants
                .Select(p => new PlantDetailsViewModel(p))
                .SingleOrDefault(p => p.Id == id);
        }

        public PlantDetailsViewModel(Models.Plant plant)
        {
            this.Id = plant.Id;
            this.PlantName = plant.PlantName;
            this.Category = plant.PlantCategory;
            this.PlantTime = plant.PlantTime;
            this.HarvestTime = plant.HarvestTime;
            this.Sun = this.Sun;
            this.Spacing = this.Spacing;
            this.Duration = plant.Duration;
            this.MaxTemp = plant.MaxTemp;
            this.MinTemp = plant.MinTemp;
        }

        public PlantDetailsViewModel()
        {

        }
    }
}
