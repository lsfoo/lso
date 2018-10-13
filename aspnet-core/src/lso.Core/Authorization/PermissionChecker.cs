using Abp.Authorization;
using lso.Authorization.Roles;
using lso.Authorization.Users;

namespace lso.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
