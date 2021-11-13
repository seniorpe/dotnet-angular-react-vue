using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Senior.Boilerplate.EntityFrameworkCore
{
    public static class BoilerplateDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BoilerplateDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BoilerplateDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
