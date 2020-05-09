using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreLesson.Middlewares.Models.Services
{
    public class Student:IEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }
    }
}
