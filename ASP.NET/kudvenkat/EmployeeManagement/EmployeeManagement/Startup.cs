using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
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
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc();
            //services.AddMvc(option => option.EnableEndpointRouting = false); 

            services.AddMvc(option => option.EnableEndpointRouting = false).AddXmlSerializerFormatters();
            //Model Service
            services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


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
            app.UseRouting();
            
            //MVC Session
            app.UseStaticFiles();
            //MVC MiddleWare
            //app.UseMvcWithDefaultRoute();

            //MVC middleware providing custom routes(Conventional Routing_
            /*
            app.UseMvc(routes =>
            {
                //{controller=Home}/{action=Index} sets the default value
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

            */

            //Atribute Route
            app.UseMvc();


            //Using app.run for learning as per KudVenkat

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World");
            });

        } 
    }
}
