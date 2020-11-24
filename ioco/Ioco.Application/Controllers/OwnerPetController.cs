using System;
using Ioco.DTO;
using Ioco.Service;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Collections.Generic;

namespace Ioco.Application.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class OwnerPetController : ApiController
    {
        // POST: api/OwnerPet
        [HttpGet]
        public List<OwnerDTO> GetOwnerPetList()
        {
            List<OwnerDTO> model = OwnerService.GetOwnerDetails();
            return model;
        }
    }
}
