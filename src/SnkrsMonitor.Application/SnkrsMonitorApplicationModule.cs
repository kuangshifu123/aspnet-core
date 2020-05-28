
using Volo.Abp.AutoMapper;

using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;


namespace SnkrsMonitor
{
    [DependsOn(
        //typeof(SnkrsMonitorDomainModule),
        //typeof(AbpAccountApplicationModule),
        //typeof(SnkrsMonitorApplicationContractsModule),
        typeof(AbpIdentityApplicationModule)
        //,
        //typeof(AbpPermissionManagementApplicationModule),
        //typeof(AbpTenantManagementApplicationModule),
        //typeof(AbpFeatureManagementApplicationModule)
        )]
    public class SnkrsMonitorApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //Configure<AbpAutoMapperOptions>(options =>
            //{
            //    options.AddMaps<SnkrsMonitorApplicationModule>();
            //});
        }
    }
}
