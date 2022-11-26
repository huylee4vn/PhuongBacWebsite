using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PhuongBac.Data.EF
{
    public class PhuongBacDbContextFactory : IDesignTimeDbContextFactory<PhuongBacDbContext>
    {
        public PhuongBacDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("PhuongBacDb");

            var optionsBuilder = new DbContextOptionsBuilder<PhuongBacDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new PhuongBacDbContext(optionsBuilder.Options);
        }
    }
}
