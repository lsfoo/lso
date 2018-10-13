using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using lso.Configuration;
using lso.Web;

namespace lso.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class lsoDbContextFactory : IDesignTimeDbContextFactory<lsoDbContext>
    {
        public lsoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<lsoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            lsoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(lsoConsts.ConnectionStringName));

            return new lsoDbContext(builder.Options);
        }
    }
}
