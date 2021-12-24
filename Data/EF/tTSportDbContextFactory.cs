using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Data.EF
{
    public class tTSportDbContextFactory : IDesignTimeDbContextFactory<tTSportDbContext>
    {
        public tTSportDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("tTSportDb");

            var optionsBuilder = new DbContextOptionsBuilder<tTSportDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new tTSportDbContext(optionsBuilder.Options);
        }
    }
}
