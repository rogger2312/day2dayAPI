using Day2Day.Core.Interfaces;
using Day2Day.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Day2Day.Api
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
            services.AddCors();

            services.AddCors(options =>
            {
                options.AddPolicy("AllowMy",
                   builder =>
                   {
                       builder.WithOrigins("*");

                   });
            });

            services.AddControllers();
            services.AddDbContext<Day2Day.Infrastructure.Data.PRY2020112V10Context>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("conn")));

            //Repositorios referenciados a Interfaces
            services.AddTransient<IPacientRepository, PacientRepository>();
            services.AddTransient<ITutorRepository, TutorRepository>();
            services.AddTransient<ISpecialistRepository, SpecialistRepository>();

            services.AddControllers().AddNewtonsoftJson(
                options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
