using Abp.Authorization;
using ScotchMe.Authorization.Roles;
using ScotchMe.Authorization.Users;

namespace ScotchMe.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
