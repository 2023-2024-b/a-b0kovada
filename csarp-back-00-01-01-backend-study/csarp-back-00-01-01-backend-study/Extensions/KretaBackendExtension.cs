namespace csarp_back_00_01_01_backend_study.Extensions
{
    public static class KretaBackendExtension
    {
        public static void AddBackend(this IServiceCollection services) {
            services.ConfigureCors();
        }

        private static void ConfigureCors(this IServiceCollection services) {
            var builder = WebApplication.CreateBuilder();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("KretaApi", policy =>
                {
                    policy.WithOrigins("http://localhost:7090", "http://10.0.2.2:7090")
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                });
            });
        }
    }
}
