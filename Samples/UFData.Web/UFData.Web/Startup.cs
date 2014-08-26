using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.DependencyInjection;
using Microsoft.AspNet.Mvc;
using System.Linq;

namespace UFData.Web
{
    public class Startup
    {
        public void Configure(IBuilder app)
        {
            // Setup configuration sources
            var configuration = new Configuration();
            configuration.AddEnvironmentVariables();

            app.UseOwin();

            // Set up application services
            app.UseServices(services =>
            {                // Add MVC services to the services container
                services.AddMvc();
                services.SetupOptions<MvcOptions>(options => {
                    System.Diagnostics.Debug.WriteLine(options.OutputFormatters.Select(item => item.GetType().Name));

                    options.OutputFormatters.RemoveAt(0);
                });
            });

            // Add static files to the request pipeline
            app.UseStaticFiles();

            // Add MVC to the request pipeline
            app.UseMvc(routes =>
            {
                //routes.MapRoute(
                //    name: "default",
                //    template: "{controller}/{action}/{id?}",
                //    defaults: new { controller = "Home", action = "Index" });

                routes.MapRoute(
                    name: "api",
                    template: "{controller}/{id?}");
            });
        }
    }
}
