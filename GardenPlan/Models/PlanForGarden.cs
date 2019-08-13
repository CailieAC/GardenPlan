using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenPlan.Models
{
    public class PlanForGarden
    {
        public int Id { get; set; }
        public List<Plant> Plants { get; set; }
    }
}
