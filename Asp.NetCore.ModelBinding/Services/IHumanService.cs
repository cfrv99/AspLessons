using Asp.NetCore.ModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore.ModelBinding.Services
{
    public interface IHumanService
    {
        List<Human> GetAll();
        Human GetHuman(int id);
        void Add(Human human);
    }
}
