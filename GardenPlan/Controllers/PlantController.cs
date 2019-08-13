using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GardenPlan.ViewModels.Plant;
using Microsoft.AspNetCore.Mvc;

namespace GardenPlan.Controllers
{
    public class PlantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            PlantCreateViewModel plantCreateViewModel = new PlantCreateViewModel();
            return View();
        }
    }
}