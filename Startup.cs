using Microsoft.Extensions.Configuration;
using System.Diagnostics.CodeAnalysis;

namespace OrderStatusService.Api
{
    [ExcludeFromCodeCoverage]
    public partial class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
    }
}
