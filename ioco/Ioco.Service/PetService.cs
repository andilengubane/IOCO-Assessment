using System;
using Ioco.Core;
using Ioco.DTO;
using System.Collections.Generic;

namespace Ioco.Service
{
    public class PetService : IPetService
    {
        private readonly UnitOfWork _uow = new UnitOfWork();

        public PetService() { }
        public List<PetDTO> GetAllPets()
        {
            try
            {
                var results = _uow.PetRepository.GetAllPets();
                return results;
            }
            catch (Exception ex)
            {
                return new List<PetDTO>();
            }
        }
    }
}
