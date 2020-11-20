using System;
using Ioco.DTO;
using System.Linq;
using Ioco.Service;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Collections.Generic;

namespace Ioco.Application.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class PetController : ApiController
    {
        // Get: api/Pet
        [System.Web.Http.HttpGet]
        public IEnumerable<SelectListItem> GetPets()
        {
            var model = new PetDTO();
            var data = model.PetList;
            return data = PetService.GetPetList(); 
        }

        // POST: api/Pet
        [System.Web.Http.HttpPost]
        public string SavePer(PetDTO model)
        {
            if (!String.IsNullOrWhiteSpace(model.PetName))
            {
                return PetService.SavePet(model); 
            }
            return "Something went wrong with collection.";
        }
    }
}
