using System;
using Ioco.DTO;
using Ioco.Core;
using System.Collections.Generic;

namespace Ioco.Service
{
    public class OnwerService : IOnwerService
    {
        private readonly UnitOfWork _uow = new UnitOfWork();
        public OnwerService() { }

        public OwnerDTO GetOwnerById(int id)
        {
            try
            {
                var results = _uow.OwnerRepository.GetOwnerByID(id);
                if (results == null || results.FirstName.Equals(String.Empty))
                {
                    return new OwnerDTO() { Error = "Record not found" };
                }
                else
                    return results;
            }
            catch (Exception ex)
            {
                return new OwnerDTO() { Error = "Something went wrong please try again later" };
            }
        }

        public List<OwnerDTO> GetAllOwner()
        {
            try
            {
                var results = _uow.OwnerRepository.GetAllOwners();
                return results;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return new List<OwnerDTO>();
            }
        }

        public OwnerDTO SaveOwner(OwnerDTO ownerDTO)
        {
            try
            {
                int result = _uow.OwnerRepository.SaveOwner(ownerDTO);
                if (result > 0)
                {
                    ownerDTO.Error = "Department saved";
                }
                else
                {
                    ownerDTO.Error = "Department saving failed";
                }
                return new OwnerDTO() { Error = "Something went wrong please try again later" };
            }
            catch (Exception ex)
            {
                return new OwnerDTO() { Error = "Something went wrong please try again later" };
            }
        }
    }
}
