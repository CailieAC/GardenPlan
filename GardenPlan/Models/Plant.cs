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
        public PlantCategory PlantCategory { get; set; }
        public string PlantTime { get; set; }
        public string HarvestTime { get; set; }
        //Add ability to select more than one sun value
        public Sun Sun { get; set; }
        public string Spacing { get; set; }
        public Duration Duration { get; set; }
        //TODO Replace max/min temp with hardiness zones
        public int MaxTemp { get; set; }
        public int MinTemp { get; set; }
        //public List<int> HardinessZones { get; set; }
    }
}
