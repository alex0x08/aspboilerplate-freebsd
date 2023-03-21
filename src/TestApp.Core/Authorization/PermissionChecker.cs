using Abp.Authorization;
using TestApp.Authorization.Roles;
using TestApp.Authorization.Users;

namespace TestApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
