using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Senior.Boilerplate.Authorization.Roles;
using Senior.Boilerplate.Authorization.Users;
using Senior.Boilerplate.MultiTenancy;

namespace Senior.Boilerplate.EntityFrameworkCore
{
    public class BoilerplateDbContext : AbpZeroDbContext<Tenant, Role, User, BoilerplateDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BoilerplateDbContext(DbContextOptions<BoilerplateDbContext> options)
            : base(options)
        {
        }
    }
}
