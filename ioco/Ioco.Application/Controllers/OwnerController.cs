using Ioco.DTO;
using Ioco.Service;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace Ioco.Application.Controllers
{
    public class OwnerController : ApiController
    {
        private readonly IOnwerService _ownerService;
        public OwnerController()
        {
            _ownerService = new OnwerService();
        }

        [HttpGet]
        public IHttpActionResult GetAllStudents()
        {
            var results = _ownerService.GetAllOwner();
            if (results != null)
            {
                return Ok(results);
            }
            return BadRequest("Something went wrong");
        }

        [HttpPost]
        public IHttpActionResult SaveStudent([FromBody] Owners owners)
        {
            OwnerDTO ownerDTO = new OwnerDTO();
            ownerDTO.FirstName = owners.firstName;
            ownerDTO.LastName = owners.lastName;
            ownerDTO.PhoneNumber = owners.phoneNumber;
            ownerDTO.PetId = owners.petId;
            ownerDTO.IdNumber = owners.idNumber;
            ownerDTO.Address = owners.address;

            var results = _ownerService.SaveOwner(ownerDTO);
            if (results != null)
            {
                return Ok(results);
            }
            return BadRequest("Something went wrong");
        }
    }
}
