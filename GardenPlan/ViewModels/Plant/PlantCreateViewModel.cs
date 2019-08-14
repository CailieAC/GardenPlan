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

        [NotMapped]
        public List<SelectListItem> Categories { get; set; }
        [NotMapped]
        public List<SelectListItem> SunReqs { get; set; }
        [NotMapped]
        public List<SelectListItem> Durations { get; set; }

        public PlantCreateViewModel()
        {
            Categories = new List<SelectListItem>();
            foreach (PlantCategory category in Enum.GetValues(typeof(PlantCategory)))
            {
                Categories.Add(new SelectListItem
                {
                    Value = ((int)category).ToString(),
                    Text = category.ToString()
                });
            }

            SunReqs = new List<SelectListItem>();
            foreach (Sun sunReq in Enum.GetValues(typeof(Sun)))
            {
                SunReqs.Add(new SelectListItem
                {
                    Value = ((int)sunReq).ToString(),
                    Text = sunReq.ToString()
                });
            }

            Durations = new List<SelectListItem>();
            foreach (Duration duration in Enum.GetValues(typeof(Duration)))
            {
                Durations.Add(new SelectListItem
                {
                    Value = ((int)duration).ToString(),
                    Text = duration.ToString()
                });
            }
        }

        public void Persist(ApplicationDbContext context)
        {
            Models.Plant plant = new Models.Plant
            {
                PlantName = this.PlantName,
                PlantCategory = this.Category,
                PlantTime = this.PlantTime,
                HarvestTime = this.HarvestTime,
                Sun = this.Sun,
                Spacing = this.Spacing,
                Duration = this.Duration,
                MaxTemp = this.MaxTemp,
                MinTemp = this.MinTemp
            };
            context.Add(plant);
            context.SaveChanges();
        }
    }
}
