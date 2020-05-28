
using Volo.Abp.Identity;

using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;


namespace SnkrsMonitor
{
    [DependsOn(
        typeof(SnkrsMonitorDomainSharedModule),
        typeof(AbpIdentityDomainModule)
      
        )]
    public class SnkrsMonitorDomainModule : AbpModule
    {
      
    }
}
