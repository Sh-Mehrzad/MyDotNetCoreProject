using DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ISCategoryService
    {
        int Add(SCategoryViewModel unit);
        void update(SCategoryViewModel unit);
        int DeActive(int unitid);
        int Delete(int unitid);
        int Active(int unitid);
        SCategoryViewModel find(int unitid);
        Task<IEnumerable<SCategoryViewModel>> GetAll();
        IEnumerable<SCategoryViewModel> getAllDeActive();
    }
}

