using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestApp.EntityFrameworkCore;
using TestApp.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace TestApp.Web.Tests
{
    [DependsOn(
        typeof(TestAppWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class TestAppWebTestModule : AbpModule
    {
        public TestAppWebTestModule(TestAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TestAppWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TestAppWebMvcModule).Assembly);
        }
    }
}