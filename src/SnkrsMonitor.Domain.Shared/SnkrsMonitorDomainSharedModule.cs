
using Volo.Abp.Identity;

using Volo.Abp.Localization;
using Volo.Abp.Modularity;

using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace SnkrsMonitor
{
    [DependsOn(
     
        typeof(AbpIdentityDomainSharedModule)
          

        )]
    public class SnkrsMonitorDomainSharedModule : AbpModule
    {
       
    }
}
