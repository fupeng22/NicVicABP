using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using NicVicABP.EntityFramework;

namespace NicVicABP
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(NicVicABPCoreModule))]
    public class NicVicABPDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<NicVicABPDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
