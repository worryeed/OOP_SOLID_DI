using OOP_SOLID_DI.Models;
using OOP_SOLID_DI.Services.ReportGenerators.Strategy;

namespace OOP_SOLID_DI.Services.ReportGenerators;

public class PlaneReportGenerator : IReportGenerator<IPlane>
{
    private readonly IReportFormatStrategy<IPlane> _formatStrategy;

    public PlaneReportGenerator(IReportFormatStrategy<IPlane> formatStrategy)
    {
        _formatStrategy = formatStrategy;
    }

    public string? GenerateReport(List<IPlane>? values)
    {
        if (values == null || values.Count == 0)
        {
            return "No data to generate report.";
        }

        return _formatStrategy.Format(values);
    }
}