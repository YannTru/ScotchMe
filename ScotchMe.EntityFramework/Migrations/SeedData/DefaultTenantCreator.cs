using System.Linq;
using ScotchMe.EntityFramework;
using ScotchMe.MultiTenancy;

namespace ScotchMe.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ScotchMeDbContext _context;

        public DefaultTenantCreator(ScotchMeDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
