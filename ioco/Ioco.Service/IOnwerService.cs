using System.Collections.Generic;
using Ioco.DTO;

namespace Ioco.Service
{
    public interface IOnwerService
    {
        List<OwnerDTO> GetAllOwner();
        OwnerDTO GetOwnerById(int id);
        OwnerDTO SaveOwner(OwnerDTO ownerDTO);
    }
}