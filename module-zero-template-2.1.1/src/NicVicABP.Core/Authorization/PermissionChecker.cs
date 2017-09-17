using Abp.Authorization;
using NicVicABP.Authorization.Roles;
using NicVicABP.Authorization.Users;

namespace NicVicABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
