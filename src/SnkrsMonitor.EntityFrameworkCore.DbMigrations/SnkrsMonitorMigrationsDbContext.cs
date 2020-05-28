using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.EntityFrameworkCore;

namespace SnkrsMonitor
{
   
    public class SnkrsMonitorMigrationsDbContext : AbpDbContext<SnkrsMonitorMigrationsDbContext>
    {
        public SnkrsMonitorMigrationsDbContext(DbContextOptions<SnkrsMonitorMigrationsDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Configure();
        }
    }
}
