using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.TenantManagement;

namespace SnkrsMonitor
{
    [DependsOn(
        //typeof(SnkrsMonitorApplicationContractsModule),
        typeof(AbpAccountHttpApiModule),
        typeof(AbpIdentityHttpApiModule),
        typeof(SnkrsMonitorApplicationModule)
        //,
        //typeof(AbpPermissionManagementHttpApiModule),
        //typeof(AbpTenantManagementHttpApiModule),
        //typeof(AbpFeatureManagementHttpApiModule)
        )]
    public class SnkrsMonitorHttpApiModule : AbpModule
    {
        
    }
}
