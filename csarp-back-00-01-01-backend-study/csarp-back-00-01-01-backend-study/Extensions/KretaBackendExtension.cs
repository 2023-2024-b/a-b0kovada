using csarp_back_00_01_01_backend_study.Contexts;
using Microsoft.EntityFrameworkCore;

namespace csarp_back_00_01_01_backend_study.Extensions
{
    public static class KretaBackendExtension
    {
        public static void AddBackend(this IServiceCollection services) {
            services.ConfigureCors();
            services.ConfigureInMemoryContext();
        }

        private static void ConfigureCors(this IServiceCollection services) {
            var builder = WebApplication.CreateBuilder();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("KretaApi", policy =>
                {
                    policy.WithOrigins("https://0.0.0.0:7090")
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                });
            });
        }

        public static void ConfigureInMemoryContext(this IServiceCollection services)
        {
            string dbNameInMemoryContext = "Kreta" + Guid.NewGuid();
            services.AddDbContext<KretaInMemoryContext>
            (
                 options => options.UseInMemoryDatabase(databaseName: dbNameInMemoryContext),
                 ServiceLifetime.Scoped,
                 ServiceLifetime.Scoped
            );
        }
    }
}

