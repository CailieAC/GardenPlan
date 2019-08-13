using GardenPlan.Data;
using GardenPlan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenPlan.ViewModels.Plant
{
    public class PlantDetailsViewModel
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
            this.PlantCategory = plant.PlantCategory;
            this.PlantDate = plant.PlantDate;
            this.HarvestDate = plant.HarvestDate;
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
