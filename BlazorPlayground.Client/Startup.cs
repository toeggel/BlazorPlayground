using BlazorPlayground.Client.Surf.Services;
using BlazorPlayground.Shared.Surf;
using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorPlayground.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Use for client side Blazor
            RegisterClientSideBlazorServices(services);

            // Use for server side Blazor
            //RegisterServerSideBlazorServices(services);
        }

        private static void RegisterServerSideBlazorServices(IServiceCollection services)
        {
            services.AddSingleton<ISurfSpotClient, SurfSpotWebSocketClient>();
            services.AddSingleton<SurfSpotService>();
        }

        private static void RegisterClientSideBlazorServices(IServiceCollection services)
        {
            services.AddSingleton<ISurfSpotClient, SurfSpotRestClient>();
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}