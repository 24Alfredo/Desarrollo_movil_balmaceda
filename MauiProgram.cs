using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;
using System.IO; // Asegúrate de incluir esta directiva
using MiAppCrud.Services; // Importa el espacio de nombres donde se encuentra UsuarioService
using MiAppCrud.Views; // Importa el espacio de nombres donde se encuentra LoginPage

namespace MiAppCrud
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Ruta de la base de datos
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "miappcrud.db");

            // Registrar servicios
            builder.Services.AddSingleton<UsuarioService>(sp => new UsuarioService(dbPath));
            builder.Services.AddSingleton<LoginPage>(); // Asegúrate de que LoginPage esté registrado

            return builder.Build();
        }
    }
}
