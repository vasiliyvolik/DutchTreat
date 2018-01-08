using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace DutchTreat
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //          if (env.IsDevelopment())
            //          {
            //              app.UseDeveloperExceptionPage();
            //          }

            //           app.Run(async (context) =>
            //           {
            //               await context.Response.WriteAsync("<html><body><h1>Hello World!</h1></body></h1>");
            //           });
            //app.UseDefaultFiles();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            


            app.UseStaticFiles();

            app.UseMvc(cfg =>
            {
                // cfg.MapRoute("Foo", "/users/manage", new { controller = "UserManagment", Action = "Index" });

                cfg.MapRoute("Default",
                    "{controller}/{action}/{id?}",
                    new { controller = "App", Action = "Index" }); 

                //если название контроллера, действие и номер не пришло то по умолчанию задать App/Index
            }
            );
        }
    }
}
