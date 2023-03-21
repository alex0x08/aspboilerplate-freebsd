using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using TestApp.EntityFrameworkCore.Seed;

namespace TestApp.EntityFrameworkCore
{
    [DependsOn(
        typeof(TestAppCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class TestAppEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<TestAppDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        TestAppDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        TestAppDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            System.AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
            System.AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior",true);
//MessageContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            IocManager.RegisterAssemblyByConvention(typeof(TestAppEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
