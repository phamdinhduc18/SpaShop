using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SpaShop.Data.EF
{
    public class SpaShopDbContextFactory : IDesignTimeDbContextFactory<SpaShopDbContext>
    {
        public SpaShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("SpaShopDatabase");

            var optionsBuilder = new DbContextOptionsBuilder<SpaShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new SpaShopDbContext(optionsBuilder.Options);
        }
    }
}
