using DTO;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IRoleService
    {
        IEnumerable<RoleViewModel> GetAll();
        IEnumerable<UsersAndRolesViewModel> GetAllUserRoleById(int userId);
        bool IsUserInRoles(string userName, string roleName);
    }
}
