using System;
using Ioco.DTO;
using Ioco.EntityFrameWork;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Ioco.Core.interfaces
{
    public interface IPetRepository : IRepository<Pet>
    {
        int SavePet(PetDTO petDTO);
        List<PetDTO> GetAllPets();
        PetDTO GetPetById(int id);
    }
}
