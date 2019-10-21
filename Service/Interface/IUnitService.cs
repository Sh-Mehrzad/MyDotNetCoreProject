using DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IUnitService
    {
        int Add(UnitViewModel unit);
        void update(UnitViewModel unit);
        int DeActive(int unitid);
        int Delete(int unitid);
        int Active(int unitid);
        UnitViewModel find(int unitid);
        Task<IEnumerable<UnitViewModel>> GetAll();
        Task<IEnumerable<UnitViewModel>> GetAll(int RoomID);        
    }
}
