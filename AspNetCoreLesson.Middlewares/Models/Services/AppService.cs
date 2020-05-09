using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreLesson.Middlewares.Models.Services
{
    public class AppService : IAppService
    {
        public void Add(Student entity)
        {
            Console.WriteLine("Added!!!");
        }

        public void AddNew(Student Entity)
        {
            return;
        }
    }

    
}


//a service and b service
//1.Factory DP
//2.DI   (IoC Container)

