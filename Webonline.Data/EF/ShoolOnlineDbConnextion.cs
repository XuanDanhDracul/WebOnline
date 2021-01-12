using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;


namespace Webonline.Data.EF
{
    class ShoolOnlineDbConnextion : IDesignTimeDbContextFactory<SchoolDbConnect>
    {
        public SchoolDbConnect CreateDbContext(string[] args)
        {
            IConfigurationRoot iconfiguration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("Appsetting.json")
                .Build();

            var ConnectionString = iconfiguration.GetConnectionString("ShopOnlineDatabase");

            var optionBuilDer = new DbContextOptionsBuilder<SchoolDbConnect>();
            optionBuilDer.UseSqlServer(ConnectionString);

            return new SchoolDbConnect(optionBuilDer.Options);
        }
    }
}
