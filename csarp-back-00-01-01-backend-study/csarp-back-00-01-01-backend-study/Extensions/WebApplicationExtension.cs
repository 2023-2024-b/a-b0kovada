using csarp_back_00_01_01_backend_study.Contexts;

namespace csarp_back_00_01_01_backend_study.Extensions
{
    public static class WebApplicationExtension
    {
        public static void ConfigureWebApp(this WebApplication app) {
            app.ConfigureWebAppCors();
            app.ConfigureInMemoryTestData();
        }

        private static void ConfigureWebAppCors(this WebApplication application) {

        application.UseCors("KretaCors");
        }
        private static void ConfigureInMemoryTestData(this WebApplication services)
        {
            using (var scope = services.Services.CreateAsyncScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<KretaInMemoryContext>();
                // InMemory test data
                dbContext.Database.EnsureCreated();
            }
        }
    }
}
