using OOP_SOLID_DI.Models;
using OOP_SOLID_DI.Services.Aerodromes;
using OOP_SOLID_DI.Services.ReportGenerators;

namespace OOP_SOLID_DI.Services;

public class AppService
{
    private readonly IAerodrome _aerodrome;
    private readonly IReportGenerator<IPlane> _reportGenerator;

    public AppService(IAerodrome aerodrome, IReportGenerator<IPlane> reportGenerator)
    {
        _aerodrome = aerodrome ?? throw new ArgumentNullException(nameof(aerodrome));
        _reportGenerator = reportGenerator ?? throw new ArgumentNullException(nameof(reportGenerator));
    }

    public void Run()
    {
        var plane1 = new Plane(1, "Plane1", 100);
        var plane2 = new Plane(2, "Plane2", 200);

        _aerodrome.Add(plane1);
        _aerodrome.Add(plane2);

        Console.WriteLine($"Plane: {plane1.Name}, State: {plane1.State}");

        _aerodrome.Launch(plane1.PlaneNumber);

        Console.WriteLine($"Plane: {plane1.Name}, State: {plane1.State}");

        _aerodrome.Add(plane1);

        Console.WriteLine($"Plane: {plane1.Name}, State: {plane1.State}");

        Console.WriteLine(_reportGenerator.GenerateReport(_aerodrome.Planes.ToList()));
    }
}