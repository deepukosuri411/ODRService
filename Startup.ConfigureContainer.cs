using Microsoft.Extensions.DependencyInjection;
using OrderStatusService.Api.MiddleWare.Configurations;

namespace OrderStatusService.Api
{
    public partial class Startup
    {
        public void ConfigureContainer(IServiceCollection container)
        {
            container.AddContainerServices();
        }
    }
}