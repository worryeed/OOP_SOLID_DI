namespace OOP_SOLID_DI.Services.ReportGenerators.Strategy;

public interface IReportFormatStrategy<T>
{
    string? Format(List<T> values);
}