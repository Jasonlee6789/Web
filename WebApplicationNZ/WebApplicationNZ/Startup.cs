using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using WebApplicationNZ.Models;

namespace WebApplicationNZ
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
            services.AddMvc();

            services.AddDbContext<WebApplicationNZContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("WebApplicationNZContext")));
            //the above line was added by the scaffolder:
  // the above <WebApplicationNZContext>coordinates EF Core functionality (Create, Read, Update, Delete, etc.) for the Movie model. 
//The above code shows the movie database context being added to the Dependency Injection container:
//services.AddDbContext<MvcMovieContext>(options => specifies the database to use and the connection string.
// => is a lambda operator

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=HelloWorld}/{action=Index}/{id?}");
            });
        }
    }
}
