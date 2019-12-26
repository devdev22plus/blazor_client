using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Blazor.FileReader;

namespace blazor_client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddFileReaderService(options => {
                options.UseWasmSharedBuffer = true;
                // The following is is a workaround for missing javascript file in Blazor 3.1 Preview 4 / ASP.NET Core 3.1.
                options.InitializeOnFirstCall = true;
            });
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
