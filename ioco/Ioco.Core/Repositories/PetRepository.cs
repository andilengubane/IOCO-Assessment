using System;
using Ioco.DTO;
using Ioco.Core.interfaces;
using Ioco.Core.Mapping;
using Ioco.EntityFrameWork;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Ioco.Core.Repositories
{
    public class PetRepository : Repository<Pet>, IPetRepository
    {
        private IocoEntities _context;
        public PetRepository(IocoEntities context) : base(context)
        {
            _context = context;
            DtoMapping.Map();
        }
        public PetDTO GetPetById(int id)
        {
            var pet = Get(id);
            return AutoMapper.Mapper.Map<PetDTO>(pet);
        }
        public int SavePet(PetDTO petDTO)
        {
            Pet pet = new Pet();
            pet.PetName = petDTO.Description;
            pet.Description = petDTO.Description;
            pet.DateLogged = petDTO.DateLogged;
            var student = AutoMapper.Mapper.Map<Pet>(pet);
            return Add(student);
        }
    }
}
