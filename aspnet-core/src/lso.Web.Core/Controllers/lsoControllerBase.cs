using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace lso.Controllers
{
    public abstract class lsoControllerBase: AbpController
    {
        protected lsoControllerBase()
        {
            LocalizationSourceName = lsoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
