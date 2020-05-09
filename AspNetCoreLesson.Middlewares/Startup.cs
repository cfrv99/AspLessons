using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreLesson.Middlewares.Extension;
using AspNetCoreLesson.Middlewares.Middlewares;
using AspNetCoreLesson.Middlewares.Models.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreLesson.Middlewares
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAppService, AppService>();
            services.AddScoped<IAppService, AppService>();
            services.AddSingleton<IAppService, AppService>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();


            //app.UseMiddleware<MyCustomMiddleware>();

            app.UseCustomMiddleware();

            //app.Run(async (context) => {
            //    if(context.Request.Path.Value.StartsWith("/Home"))
            //    {
            //       await context.Response.WriteAsync("Access denide");
            //    }
                
            //    else
            //    {
            //        await context.Response.WriteAsync("Murad geldi");
            //    }
            //});
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
