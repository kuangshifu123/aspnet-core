using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace SnkrsMonitor
{
    [DependsOn(
       typeof(SnkrsMonitorFrameworkCoreModule)
   )]
    public class SnkrsMonitorEntityFrameworkCoreDbMigrationsModule: AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<SnkrsMonitorMigrationsDbContext>();
        }
    }
}
