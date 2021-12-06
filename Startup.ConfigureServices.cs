using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using OrderStatusService.Api.MiddleWare.Configurations;
using OrderStatusService.Api.MiddleWare.Formatter;

namespace OrderStatusService.Api
{
    public partial class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            AddCustom(services);
            AddMvc(services);
        }

        public void AddMvc(IServiceCollection services)
        {
            services.AddMvc(options =>
            {
                options.OutputFormatters.Insert(0, new OutputFormatter(Configuration));
            })
            .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            //.AddFluentValidation(fvc => fvc.RegisterValidatorsFromAssemblyContaining<Startup>());
        }

        private void AddCustom(IServiceCollection services)
        {
            services.AddCustomServices(Configuration);
        }
    }
}
