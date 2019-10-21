using DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IPropertyService
    {
        Task<int> Add(PropertyViewModel unit);
        void update(PropertyViewModel unit);
        int DeActive(int unitid);
        int Delete(int unitid);
        int Active(int unitid);
        PropertyViewModel find(int unitid);
        Task<IList<PropertyViewModel>> GetAll(int UnitID, int CategoryID );
        Task<IList<PropertyViewModel>> GetAll(int UnitID);
        Task<IList<PropertyViewModel>> GetAllPropertiesInCategory(int CategoryID);
        IEnumerable<PropertyViewModel> getAllDeActive();
        int CountOfProperty();
        int CountOfPropertyWithUnit(int UnitID);
        int CountOfPropertyWithCategory(int CategoryID);
        int CountOfProperty(int UnitID, int CategoryID);
    }
}
