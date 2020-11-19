using Ioco.Service;
using System.Web.Http;

namespace Ioco.Application.Controllers
{
    public class PetController : ApiController
    {
        private readonly IPetService _petService;

        public PetController()
        {
            _petService = new PetService();
        }

        [HttpGet]
        public IHttpActionResult GetAllPets()
        {
            var results = _petService.GetAllPets();

            if (results != null)
            {
                return Ok(results);
            }
            return BadRequest("Something went wrong");
        }
    }
}
