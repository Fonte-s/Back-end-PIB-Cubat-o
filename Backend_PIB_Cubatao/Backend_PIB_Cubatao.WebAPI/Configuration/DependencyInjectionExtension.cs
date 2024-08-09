using System.Reflection;
using Backend_PIB_Cubatao.Infrastructure.Configurations;
using MediatR;

namespace Backend_PIB_Cubatao.WebAPI.Configuration
{
    public static class DependencyInjectionExtension
    {
        public static void AddWebAPI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddInfrastructure(configuration);

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }
        private static void UseWebAPISwagger(this WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
        }
        private static void UseWebAPICors(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseCors((options) =>
                {
                    options.AllowAnyOrigin();
                    options.AllowAnyHeader();
                    options.AllowAnyMethod();
                });
            }
            //!TODO: Config das políticas do CORS
        }
        public static void UseWebAPI(this WebApplication app)
        {
            app.UseInfraestructure();
            app.UseWebAPISwagger();
            app.UseWebAPICors();
            app.UseAuthorization();
            app.MapControllers();
        }
    }
}