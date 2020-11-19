using System.Collections.Generic;
using Ioco.DTO;

namespace Ioco.Service
{
    public interface IPetService
    {
        List<PetDTO> GetAllPets();
    }
}