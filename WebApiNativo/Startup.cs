using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Infraestructure.Data.Repositories;
using Domain.Domain.Interfaces;
using Domain.Domain.Interfaces.Services;
using Business.Main.Services;

namespace WebApiNativo
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
            services.AddControllers();
            services.AddDbContext<NativoContext>(options => options.UseSqlServer(Configuration.GetConnectionString("sqlConnection")));
            services.AddScoped<INeighborhoodsRepository, NeighborhoodsRepository>();
            services.AddScoped<INeighborhoodsService, NeighborhoodService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors(x => x
               .AllowAnyMethod()
               .AllowAnyHeader()
               .SetIsOriginAllowed(origin => true) 
               .AllowCredentials()); 
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>{ endpoints.MapControllers(); });
        }
    }
}
