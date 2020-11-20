﻿using System;
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
                    //InventoryTypeId = model.InventoryTypeId,
                    //Name = model.Name,
                    //SerialNumber = model.SerialNumber,
                    //Model = model.Model,
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
                //Name = x.Name,
                //SerialNumber = x.SerialNumber,
                //Model = x.Model,
                //IsAssigned = x.IsAssigned,
                //EmployeeNumber = x.EmployeeNumber,
                //FullName = x.FULLNAME
            }).ToList();
            return data;
        }
    }
}
