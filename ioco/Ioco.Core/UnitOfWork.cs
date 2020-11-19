using System;
using Ioco.EntityFrameWork;
using Ioco.Core.Repositories;
using Ioco.Core.interfaces;
using System.Data.Entity.Validation;

namespace Ioco.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IocoEntities _context;
        private IOwnerRepository _ownerRepository;
        private IPetRepository _petRepository;

        public UnitOfWork()
        {
            if (_context == null)
                _context = new IocoEntities();
        }

        public IOwnerRepository OwnerRepository
        {
            get
            {
                return _ownerRepository ?? (_ownerRepository = new OwnerRepository(_context));
            }
        }
        public IPetRepository PetRepository
        {
            get
            {
                return _petRepository ?? (_petRepository = new PetRepository(_context));
            }
        }
        public int Complete()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        var c = validationErrors.Entry.Entity.GetType().FullName;
                        var a = validationError.PropertyName;
                        var b = validationError.ErrorMessage;
                    }
                }
                return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
