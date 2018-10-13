using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using lso.Authorization.Roles;
using lso.Authorization.Users;
using lso.MultiTenancy;

namespace lso.EntityFrameworkCore
{
    public class lsoDbContext : AbpZeroDbContext<Tenant, Role, User, lsoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public lsoDbContext(DbContextOptions<lsoDbContext> options)
            : base(options)
        {
        }
    }
}
