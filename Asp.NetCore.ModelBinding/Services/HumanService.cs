using Asp.NetCore.ModelBinding.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore.ModelBinding.Services
{
    public class HumanService : IHumanService
    {
        static List<Human> Humans = new List<Human>()
        {
            new Human{Id=1,Name = "Murad",Surname="Cafrov",Age=15}
        };

        public void Add(Human human)
        {
            int newId = Humans.Max(i => i.Id) + 1;
            human.Id = newId;
            Humans.Add(human);
        }
        public List<Human> GetAll()
        {
            return Humans;
        }

        public Human GetHuman(int id)
        {
            return Humans.Find(i => i.Id == id);
        }
    }
}
