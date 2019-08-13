using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GardenPlan.Controllers
{
    public class PlanForGardenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}