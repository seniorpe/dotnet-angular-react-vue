using Abp.Authorization;
using Senior.Boilerplate.Authorization.Roles;
using Senior.Boilerplate.Authorization.Users;

namespace Senior.Boilerplate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
