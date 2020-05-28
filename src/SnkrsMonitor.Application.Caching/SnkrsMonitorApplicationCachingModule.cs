using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Caching;
using Volo.Abp.Modularity;
namespace SnkrsMonitor.Application.Caching
{
    [DependsOn(
        typeof(AbpCachingModule),
        typeof(SnkrsMonitorDomainModule)
               
    // ...
    )]
    public class SnkrsMonitorApplicationCachingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
        }
    }
}
