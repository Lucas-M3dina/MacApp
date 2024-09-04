using Mac.MAUI.Biz.Interface;
using Mac.MAUI.Biz.Service;
using Mac.MAUI.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Mac.MAUI
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
                });

            builder.Services.AddMauiBlazorWebView();

            builder.Services.AddDbContext<MacAppContext>(options =>
                options.UseSqlServer("Server=192.168.1.107;Database=MacApp;User Id=sa;Password=mac123;TrustServerCertificate=True"));
            builder.Services.AddScoped<IContratoService,ContratoService>();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
