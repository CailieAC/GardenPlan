using GardenPlan.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenPlan.ViewModels.Plant
{
    public class PlantListItemViewModel
    {
        public static List<PlantListItemViewModel> GetPlants(ApplicationDbContext context)
        {
            return context.Plants
                .Select(p => new PlantListItemViewModel(p))
                .ToList();
        }

        public PlantListItemViewModel(Models.Plant plant)
        {
            this.Id = plant.Id;
            this.PlantName = plant.PlantName;

        }

        public int Id { get; set; }
        public string PlantName { get; set; }
    }
}
