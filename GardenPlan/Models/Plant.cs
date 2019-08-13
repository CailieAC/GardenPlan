using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenPlan.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string PlantName { get; set; }
        //change to enum later
        public string PlantCategory { get; set; }
        public DateTime PlantDate { get; set; }
        public DateTime HarvestDate { get; set; }
        public string Water { get; set; }
        //change to enum later
        public string Sun { get; set; }
        public string Spacing { get; set; }
    }
}
