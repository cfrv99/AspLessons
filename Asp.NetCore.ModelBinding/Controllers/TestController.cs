using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.NetCore.ModelBinding.Models;
using Asp.NetCore.ModelBinding.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Asp.NetCore.ModelBinding.Controllers
{
    public class TestController : Controller
    {
        private readonly IHumanService humanService;

        public TestController(IHumanService humanService)
        {
            this.humanService = humanService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        //FromBody/FromForm
        [HttpPost]
        public IActionResult Index([FromForm]Human human)
        {
            return View();
        }

        public IActionResult GetAllHumans()
        {
            var json = JsonConvert.SerializeObject(humanService.GetAll());
            return Content(json);
        }
        [HttpPost]
        public IActionResult Add([FromBody]Human human)
        {
            humanService.Add(human);
            var json = JsonConvert.SerializeObject(humanService.GetAll());
            return Content(json);
        }
        [HttpGet]
        public IActionResult GetDetail([FromQuery]int id)
        {
            var human = humanService.GetHuman(id);
            string json = JsonConvert.SerializeObject(human);
            return Content(json);
        }

    }
}