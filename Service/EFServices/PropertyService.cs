using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Context;
using Data.Entities;
using DTO;
using Repo;
using Service.Interface;

namespace Service.EFServices
{
    public class PropertyService : IPropertyService
    {

        private readonly IUnitOfWork _uow;
        private readonly IGenericRepository<Property> _property;

        public PropertyService(IUnitOfWork uow, IGenericRepository<Property> property)
        {
            _uow = uow;
            _property = property;
        }

        public int Active(int unitid)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> Add(PropertyViewModel unit)
        {
            throw new System.NotImplementedException();
        }
                
        public int DeActive(int unitid)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(int unitid)
        {
            throw new System.NotImplementedException();
        }

        public PropertyViewModel find(int unitid)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IList<PropertyViewModel>> GetAll(int UnitID, int CategoryID)
        {
            var list = _property.FindBy(x => x.UnitID == UnitID && x.CategoryID == CategoryID).ToList();
            
            return list.Select(x => new PropertyViewModel
            {
                ID = x.ID,                
                Title = x.Title,
                Description = x.Description,
                PropertyCode = x.PropertyCode
            }).ToList();
        }

        public async Task<IList<PropertyViewModel>> GetAll(int UnitID)
        {
            var list =  _property.FindBy(x => x.UnitID == UnitID).ToList();

            return list.Select(x => new PropertyViewModel
            {
                ID = x.ID,
                Title = x.Title,
                Description = x.Description,
                PropertyCode = x.PropertyCode
            }).ToList();
        }

        public IEnumerable<PropertyViewModel> getAllDeActive()
        {
            throw new System.NotImplementedException();
        }

        public async Task<IList<PropertyViewModel>> GetAllPropertiesInCategory(int CategoryID)
        {
            var list = _property.FindBy(x => x.CategoryID == CategoryID).ToList();

            return list.Select(x => new PropertyViewModel
            {
                ID = x.ID,
                Title = x.Title,
                Description = x.Description,
                PropertyCode = x.PropertyCode
            }).ToList();
        }

        public void update(PropertyViewModel unit)
        {
            throw new System.NotImplementedException();
        }
                
        public int CountOfProperty(int UnitID, int CategoryID)
        {            
            return _property.FindBy(x => x.CategoryID == CategoryID && x.UnitID == UnitID).Count();            
        }

        public int CountOfProperty()
        {
            return  _property.GetCountAsync().Result;           
        } 

        public int CountOfPropertyWithUnit(int UnitID)
        {
            return _property.FindBy(x => x.UnitID == UnitID).Count();
        }

        public int CountOfPropertyWithCategory(int CategoryID)
        {
            return _property.FindBy(x => x.CategoryID == CategoryID).Count();
        }
    }
}
