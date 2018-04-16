using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ScotchMe.EntityFramework;

namespace ScotchMe.Migrator
{
    [DependsOn(typeof(ScotchMeDataModule))]
    public class ScotchMeMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ScotchMeDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}