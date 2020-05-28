using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


namespace SnkrsMonitor.HttpApi.Hosting
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication <SnkrsMonitorHttpApiHostingModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
