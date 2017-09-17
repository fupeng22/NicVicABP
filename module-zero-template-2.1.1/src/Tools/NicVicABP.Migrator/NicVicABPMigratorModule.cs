using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using NicVicABP.EntityFramework;

namespace NicVicABP.Migrator
{
    [DependsOn(typeof(NicVicABPDataModule))]
    public class NicVicABPMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<NicVicABPDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}