using DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IRoomService
    {
        int Add(RoomViewModel unit);
        void update(RoomViewModel unit);
        int DeActive(int unitid);
        int Delete(int unitid);
        int Active(int unitid);
        RoomViewModel find(int unitid);
        Task<IEnumerable<RoomViewModel>> GetAll();
        IEnumerable<RoomViewModel> getAllDeActive();
    }
}
