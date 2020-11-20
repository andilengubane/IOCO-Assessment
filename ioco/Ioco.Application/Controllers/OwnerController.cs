using System;
using Ioco.DTO;
using Ioco.Service;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Collections.Generic;

namespace Ioco.Application.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class OwnerController : ApiController
    {
        // POST: api/Owner
        [HttpGet]
        public List<OwnerDTO> GetList()
        {
            List<OwnerDTO> model = OwnerService.GetOwnerDetails();
            return model;
        }

        // POST: api/Owner
        [HttpPost]
        public string SaveOwner(OwnerDTO model)
        {
            if (!String.IsNullOrWhiteSpace(model.IdNumber))
            {
                return OwnerService.SaveOwner(model); 
            }
            return "Something went wrong with collection.";
        }
    }
}
