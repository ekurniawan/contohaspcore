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

namespace contohaspcore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //menginject modul
            services.AddSingleton<IGreeter,Greeter>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
        IConfiguration config, IGreeter greeter)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //contoh middleware
            app.UseRouting();

            /*app.Use(async(context,next)=>{
                if(context.Request.Path.Value.Contains("home")){
                    await context.Response.WriteAsync("Response dr middleware");
                }
                else {
                    Console.WriteLine("== Before Run ==");
                    await next.Invoke();
                    Console.WriteLine("== After Run ==");
                }
            });

            app.Run(async(context)=>{
                Console.Write("Dijalankan pada saat method run");
                await context.Response.WriteAsync("Hello from middleware\n");
            });*/

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    var greetings = greeter.GetMessageOfTheDay();
                    await context.Response.WriteAsync($"Pesan: {greetings}");
                });
            });
        }
    }
}
