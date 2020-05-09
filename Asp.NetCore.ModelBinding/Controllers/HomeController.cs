using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Asp.NetCore.ModelBinding.Models;

namespace Asp.NetCore.ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index([FromQuery]string name)
        {
            //Header
            //Body
            //Method
            //Path
            
            return View();
        }
        [HttpPost]
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
