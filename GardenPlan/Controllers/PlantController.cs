using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GardenPlan.Data;
using GardenPlan.Models;
using GardenPlan.ViewModels.Plant;
using Microsoft.AspNetCore.Mvc;

namespace GardenPlan.Controllers
{
    public class PlantController : Controller
    {
        private ApplicationDbContext context;
        public PlantController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            //List<PlantListItemViewModel> plants = PlantListItemViewModel.GetPlants(context);
            //return View(plants);
            List<Plant> plants = context.Plants.ToList();
            return View(plants);
        }

        [HttpGet]
        public IActionResult Create()
        {
            PlantCreateViewModel plantCreateViewModel = new PlantCreateViewModel();
            return View(plantCreateViewModel);
        }

        [HttpPost]
        public IActionResult Create(PlantCreateViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            model.Persist(context);
            return RedirectToAction(controllerName: "Plant", actionName: "Index");
        }

        [HttpGet]
        public IActionResult Details(int plantId)
        {
            PlantDetailsViewModel plant = PlantDetailsViewModel.GetPlant(plantId, context);
            return View(plant);
        }
    }
}