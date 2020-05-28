using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SnkrsMonitor
{
    
    public class SnkrsMonitorMigrationsDbContextFactory : IDesignTimeDbContextFactory<SnkrsMonitorMigrationsDbContext>
    {
        public SnkrsMonitorMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<SnkrsMonitorMigrationsDbContext>().UseSqlServer
                (configuration.GetConnectionString("Default"));

            return new SnkrsMonitorMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build();
        }

       
    }
}
