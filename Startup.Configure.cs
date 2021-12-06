using Microsoft.AspNetCore.Builder;
using OrderStatusService.Api.MiddleWare.Configurations;

namespace OrderStatusService.Api
{
    public partial class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.AddCustomConfiguration();
        }
    }
}
