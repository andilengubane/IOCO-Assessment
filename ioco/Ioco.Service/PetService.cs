using System;
using Ioco.DTO;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using Ioco.EntityFrameWork;
using System.Collections.Generic;

namespace Ioco.Service
{
    public class PetService
    {
        private readonly static IOCOEntities context = new IOCOEntities();
        public static string SavePet(PetDTO model)
        {
            if (model.Id == 0)
            {
                context.Pet.Add(new Pet
                {
                    PetName = model.PetName,
                    Description = model.Description,
                    DateLogged = DateTime.Now
                });
                context.SaveChanges();
            }
            return "Pet was successful added";
        }

        public static IEnumerable<SelectListItem> GetPetList()
        {
            var query = context.Pet.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.PetName
            });
            return new SelectList(query, "Value", "Text");
        }
    }
}
