using System;
using System.Web.Mvc;
using System.Collections.Generic;

namespace Ioco.DTO
{
    public class PetDTO
    {
        public int Id { get; set; }
        public string PetName { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DateLogged { get; set; }
        public IEnumerable<SelectListItem> PetList { get; set; }
    }
}
