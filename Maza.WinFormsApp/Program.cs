using Microsoft.Extensions.DependencyInjection;
using Maza.Application.Services;
using Maza.Data;

namespace Maza.WinFormsApp
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Configurar Inyección de Dependencias
            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();

            // Ejecutar la aplicación inyectando las dependencias en Home
            System.Windows.Forms.Application.Run(ServiceProvider.GetRequiredService<Home>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Registrar los formularios
            services.AddTransient<Home>();
            services.AddTransient<AgregarPromo>();
            services.AddTransient<ExpirarPromo>();
            services.AddTransient<ConsultarPromoEstado>();

            // Registrar servicios de la aplicación
            services.AddScoped<IPromocionRepository, PromocionRepository>();
            services.AddScoped<IPromocionService, PromocionService>();
        }
    }
}