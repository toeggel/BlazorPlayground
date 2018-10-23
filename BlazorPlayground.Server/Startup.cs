using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using BlazorPlayground.Shared.Surf;
using ElectronNET.API;
using Microsoft.AspNetCore.Blazor.Server;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorPlayground.Server
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Use client side Blazor.
            ConfigureClientSideBlazorServices(services);

            // Use server side Blazor.
            //ConfigureServerSideBlazorServices(services);

            services.AddResponseCompression(options =>
            {
                options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[]
                {
                    MediaTypeNames.Application.Octet,
                    WasmMediaTypeNames.Application.Wasm
                });
            });

            services.AddSingleton<SurfSpotService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseResponseCompression();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Use for client side Blazor.
            ConfigureClientSideBlazor(app);

            // Use for server side Blazor.
            //ConfigureServerSideBlazor(app);

            Task.Run(async () => await Electron.WindowManager.CreateWindowAsync());
        }

        private static void ConfigureServerSideBlazorServices(IServiceCollection services)
        {
            services.AddServerSideBlazor<Client.Startup>();
        }

        private static void ConfigureServerSideBlazor(IApplicationBuilder app)
        {
            app.UseServerSideBlazor<Client.Startup>();
        }

        private static void ConfigureClientSideBlazorServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        private static void ConfigureClientSideBlazor(IApplicationBuilder app)
        {
            app.UseMvc(routes => { routes.MapRoute("default", "{controller}/{action}/{id?}"); });
            app.UseBlazor<Client.Startup>();
        }
    }
}