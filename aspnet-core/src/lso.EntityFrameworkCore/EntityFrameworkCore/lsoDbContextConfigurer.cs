using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace lso.EntityFrameworkCore
{
    public static class lsoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<lsoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<lsoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
