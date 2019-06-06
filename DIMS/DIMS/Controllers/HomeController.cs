using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DIMS.Models;
using DIMS.Models.Methods;

namespace DIMS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            RaInforManagement method = new RaInforManagement();

            method.AddBuildingRa("1607", "1");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
