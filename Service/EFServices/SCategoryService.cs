using Data.Context;
using Data.Entities;
using DTO;
using Repo;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.EFServices
{
    public class SCategoryService : ISCategoryService
    {

        private readonly IUnitOfWork _uow;
        private readonly IGenericRepository<SuppliesCategory> _scategory;

        public SCategoryService(IUnitOfWork uow, IGenericRepository<SuppliesCategory> scategory)
        {
            _uow = uow;
            _scategory = scategory;
        }

        public int Active(int unitid)
        {
            throw new NotImplementedException();
        }

        public int Add(SCategoryViewModel unit)
        {
            throw new NotImplementedException();
        }

        public int DeActive(int unitid)
        {
            throw new NotImplementedException();
        }

        public int Delete(int unitid)
        {
            throw new NotImplementedException();
        }

        public SCategoryViewModel find(int unitid)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SCategoryViewModel>> GetAll()
        {
            var list = await _scategory.GetAllAsync();
            return list.Select(x => new SCategoryViewModel
            {
                ID = x.ID,
                Title = x.Title
            }).ToList();
        }

        public IEnumerable<SCategoryViewModel> getAllDeActive()
        {
            throw new NotImplementedException();
        }

        public void update(SCategoryViewModel unit)
        {
            throw new NotImplementedException();
        }
    }
}
