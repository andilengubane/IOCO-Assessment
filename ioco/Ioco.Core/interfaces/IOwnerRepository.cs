using System;
using Ioco.DTO;
using Ioco.Core.Mapping;
using Ioco.Core.interfaces;
using Ioco.EntityFrameWork;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Ioco.Core.interfaces
{
    public interface IOwnerRepository : IRepository<Owner>
    {
        int SaveOwner(OwnerDTO ownerDTO);
        List<OwnerDTO> GetOwners(Expression<Func<Owner, bool>> predicate);
        OwnerDTO GetOwnerByID(int id);
        List<OwnerDTO> GetAllOwners();
    }
}
