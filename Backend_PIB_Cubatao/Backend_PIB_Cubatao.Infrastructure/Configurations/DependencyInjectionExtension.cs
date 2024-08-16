using Backend_PIB_Cubatao.Domain.Entities;
using Backend_PIB_Cubatao.Domain.Interfaces;
using Backend_PIB_Cubatao.Infrastructure.Context;
using Backend_PIB_Cubatao.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Backend_PIB_Cubatao.Infrastructure.Configurations
{
    public static class DependencyInjectionExtension
    {
        private static void AddIdentity(this IServiceCollection services)
        {
            services.AddIdentity<Usuario, IdentityRole>()
                .AddEntityFrameworkStores<AppIdentityDbContext>()
                .AddDefaultTokenProviders();
        }
        private static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
        private static void MigrateDatabase(this IServiceCollection services)
        {
            using var provider = services.BuildServiceProvider();
            using var scope = provider.CreateScope();
            using var DbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            DbContext.Database.Migrate();
        }
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var mySqlConnection = configuration.GetConnectionString("DefaultConnection") ?? throw new ArgumentNullException("Connection string not found");
            services.AddDbContext<AppDbContext>(options =>
            options.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection)));
            services.AddDbContext<AppIdentityDbContext>(options =>
            options.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection)));
            services.AddIdentity();
            services.AddRepositories();
            services.MigrateDatabase();
        }
    }
}