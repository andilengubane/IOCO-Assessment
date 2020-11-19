using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioco.DTO
{
    public class PetDTO
    {
        public int Id { get; set; }
        public string PetName { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DateLogged { get; set; }
    }
}
