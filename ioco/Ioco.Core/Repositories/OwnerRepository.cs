using System;
using Ioco.DTO;
using Ioco.Core.Mapping;
using Ioco.Core.interfaces;
using Ioco.EntityFrameWork;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Ioco.Core.Repositories
{
    public class OwnerRepository : Repository<Owner>, IOwnerRepository
    {
        private IocoEntities _context;

        public OwnerRepository(IocoEntities context) : base(context)
        {
            _context = context;
            DtoMapping.Map();
        }

        public List<OwnerDTO> GetOwners(Expression<Func<Owner, bool>> predicate)
        {
            var results = Find(predicate);
            return AutoMapper.Mapper.Map<List<OwnerDTO>>(results);
        }

        public List<OwnerDTO> GetAllOwners()
        {
            var results = GetAll(); ;
            return AutoMapper.Mapper.Map<List<OwnerDTO>>(results);
        }

        public OwnerDTO GetOwnerByID(int id)
        {
            var owner = Get(id);
            return AutoMapper.Mapper.Map<OwnerDTO>(owner);
        }
        public int SaveOwner(OwnerDTO ownerDTO)
        {
            var owner = AutoMapper.Mapper.Map<Owner>(ownerDTO);
            return Add(owner);
        }
    }
}
