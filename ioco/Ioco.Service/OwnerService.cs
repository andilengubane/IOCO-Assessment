using System;
using Ioco.DTO;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using Ioco.EntityFrameWork;
using System.Collections.Generic;


namespace Ioco.Service
{
    public class OwnerService
    {
        private readonly static IOCOEntities context = new IOCOEntities();
        public static string SaveOwner(OwnerDTO model)
        {
            if (model.Id == 0)
            {
                context.Owner.Add(new Owner
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    PetId = model.PetId,
                    PhoneNumber = model.PhoneNumber,
                    IdNumber = model.IdNumber,
                    DateLogged = DateTime.Now
                });
                context.SaveChanges();
            }
            return "";
        }

        public static List<OwnerDTO> GetOwnerDetails()
        {
            List<OwnerDTO> data = context.Owner.Select(x => new OwnerDTO
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Address = x.Address,
                PetId = Convert.ToInt32(x.PetId),
                PhoneNumber = x.PhoneNumber,
                IdNumber = x.IdNumber,
                DateLogged = Convert.ToDateTime(x.DateLogged)
            }).ToList();
            return data;
        }
    }
}
