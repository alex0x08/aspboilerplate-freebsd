using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestApp.Authorization;

namespace TestApp
{
    [DependsOn(
        typeof(TestAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TestAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TestAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TestAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
