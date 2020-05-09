using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreLesson.Middlewares.Models.Services
{
    public interface IAppService
    {
        void Add(Student entity);
    }
}
