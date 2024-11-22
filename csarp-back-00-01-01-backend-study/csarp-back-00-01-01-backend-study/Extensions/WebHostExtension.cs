namespace csarp_back_00_01_01_backend_study.Extensions
{
    public static class WebHostExtension
    {
        public static void ConfigureWebHost(this WebApplicationBuilder webHostBuilder){
            webHostBuilder.WebHost.UseUrls("https://0.0.0.0:7090");

        }
    }
}
