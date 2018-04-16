using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using ScotchMe.EntityFramework;

namespace ScotchMe
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(ScotchMeCoreModule))]
    public class ScotchMeDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ScotchMeDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
