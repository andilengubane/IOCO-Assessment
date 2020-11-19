using System;

namespace Ioco.DTO
{
    public class Owners
    {
        public int id { get; set; }
        public int petId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string idNumber { get; set; }
        public string address { get; set; }
        public DateTime dateLogged { get; set; }
        public string Error { get; set; }
    }

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
        public string Error { get; set; }
    }
}
