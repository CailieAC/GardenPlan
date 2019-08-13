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
    }
}
