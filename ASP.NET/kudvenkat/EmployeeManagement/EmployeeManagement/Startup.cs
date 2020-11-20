using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EmployeeManagement
{
    public class Startup
    {
        private IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // The commented part is the default functionality. So used app.Run as per tutorial for learning

            /*
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    //Print the process name on web
                    //await context.Response.WriteAsync(System.Diagnostics.Process.GetCurrentProcess().ProcessName);

                    //Accessing Appsettings.Json
                    //await context.Response.WriteAsync(_config["MyKey"]);

                    await context.Response.WriteAsync("Hello World!");
                });
            });

            */

            //Using app.run for learning as per KudVenkat
             
            //Middleware 1
            app.Use(async (context , next) =>
            {
                logger.LogInformation("Middleware 1 : Incoming Request");
                await context.Response.WriteAsync("Middleware 1");
                await next();
                logger.LogInformation("Middleware 1 : Outgoing Response");
            });
            //Middleware 2
            app.Use(async (context, next) =>
            {
                logger.LogInformation("Middleware 2 : Incoming Request");
                await context.Response.WriteAsync("Middleware 2");
                await next();
                logger.LogInformation("Middleware 2 : Outgoing Response");
            });
            //Middleware 3
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Middleware 3 : Request Handled");
                logger.LogInformation("Middleware 3 : Request Handled");
            });

        } 
    }
}
