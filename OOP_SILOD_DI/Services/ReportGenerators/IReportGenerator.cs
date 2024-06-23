namespace OOP_SOLID_DI.Services.ReportGenerators;

public interface IReportGenerator<T>
{
    string? GenerateReport(List<T>? values);
}