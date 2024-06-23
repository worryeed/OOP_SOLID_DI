using Microsoft.Extensions.DependencyInjection;
using OOP_SOLID_DI.Models;
using OOP_SOLID_DI.Services;
using OOP_SOLID_DI.Services.Aerodromes;
using OOP_SOLID_DI.Services.ReportGenerators;
using OOP_SOLID_DI.Services.ReportGenerators.Strategy;

namespace OOP_SOLID_DI;

public static class Program
{
    public static void Main()
    {
        var serviceProvider = ConfigureServices();

        using (var scope = serviceProvider.CreateScope())
        {
            var appService = scope.ServiceProvider.GetRequiredService<AppService>();
            appService.Run();
        }
    }

    public static IServiceProvider ConfigureServices()
    {
        return new ServiceCollection()
            .AddSingleton<IReportFormatStrategy<IPlane>, PlaneReportFormatStrategy>()
            .AddSingleton<IReportGenerator<IPlane>, PlaneReportGenerator>()
            .AddTransient<IAerodrome, Aerodrome>()
            .AddSingleton<AppService>()
            .BuildServiceProvider();
    }
}