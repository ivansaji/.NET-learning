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
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            //Default Files enable
            //app.UseDefaultFiles();
            //Static Files Middleware
            //app.UseStaticFiles();

            // Alternate method
            FileServerOptions fileServerOptions = new FileServerOptions();
            fileServerOptions.DefaultFilesOptions.DefaultFileNames.Clear();
            fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("foo.html");
            app.UseFileServer(fileServerOptions);


            //Using app.run for learning as per KudVenkat
             
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World");
            });

        } 
    }
}
