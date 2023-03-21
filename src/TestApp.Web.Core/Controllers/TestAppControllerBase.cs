using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TestApp.Controllers
{
    public abstract class TestAppControllerBase: AbpController
    {
        protected TestAppControllerBase()
        {
            LocalizationSourceName = TestAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
