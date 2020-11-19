using System;

namespace Ioco.DTO
{
    public class OwnerDTO
    {
        public int Id { get; set; }
        public int PetId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string IdNumber { get; set; }
        public string Address { get; set; }
        public DateTime DateLogged { get; set; }
    }
}
