using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreLesson.Middlewares.Models;
using AspNetCoreLesson.Middlewares.Models.Services;

namespace AspNetCoreLesson.Middlewares.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAppService appService;

        public HomeController(IAppService appService)
        {
            this.appService = appService;
        }
        public IActionResult Index()
        {
            AppService app = new AppService(); //sehvdir chunki ozunde business logica saxlayir . Yeni Programin life syscleni teyin eden methodlar var
            Student s = new Student();
            appService.Add(new Student());    //duzdur cunki ozunde hec bir business logic saxlamir
            return View();
        }
        public IActionResult Privacy()
        {

            appService.Add(new Student());
            /*
             Solid
             S - Single of Responsibility 
             O - Open/Closed
             L-Liskovs Substition
             I - interface segregation
             D - Dependecy Inversion/Injection
             Proekt eger hazir varsa ,  Senin kodun genishlenirmeye elverishli olmalidi,
             ama genishlendirilende hec bir shey deyidirmemelisen

            class AwsCompanyUser:Person{
                
            }
            class MicrosoftCompanyUser:Person{

            }
            void Sucess(Person p){

            }
            Success(AwsCompanyUser s);
            Object


             */
            IAppService app = new AppService();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
